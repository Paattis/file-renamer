using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace filerenamer
{
    public partial class btn_selectFiles : Form
    {

        public string mode = "allsame";
        public btn_selectFiles()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            //initialize the file selection dialog
            this.openFileDialog1.Filter = "Images (*.BMP;*.PNG;*.JPG;*.GIF)|*.BMP;*.PNG;*.JPG;*.GIF|" + "Audio files (*.MP3;*.FLAC;*.WAV)|*.MP3;*.FLAC;*.WAV|" + "All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select the files to rename";

            //show the file selection dialog
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Array files = openFileDialog1.FileNames.ToArray();

                foreach (string file in files)
                {
                    txt_selectedfiles.AppendText(file+"\r\n");
                }

                btn_startRenaming.Enabled = true;
            }
            else if (dr == DialogResult.Cancel)
            {
                //User pressed cancel
            }
        }

       
                
        private void radio_regexPattern_CheckedChanged(object sender, EventArgs e)
        {
            //make the radio buttons switch between the two modes
            if (radio_regexPattern.Checked == false)
            {
                lbl_regexPattern.Visible = false;
                lbl_replaceWith.Visible = false;

                txt_regex.Visible = false;
                txt_replaceText.Visible = false;
                                
            }
            else
            {
                lbl_regexPattern.Visible = true;
                lbl_replaceWith.Visible = true;

                txt_regex.Visible = true;
                txt_replaceText.Visible = true;

                mode = "regexreplace";
            }
        }

        private void radio_newtext_CheckedChanged(object sender, EventArgs e)
        {
            //make the radio buttons switch between the two modes
            if (radio_newtext.Checked == false)
            {
                lbl_newFilename.Visible = false;
                txt_newFilename.Visible = false;
            }
            else
            {
                lbl_newFilename.Visible = true;
                txt_newFilename.Visible = true;

                mode = "allsame";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /* rename the files */

            Array files = this.openFileDialog1.FileNames.ToArray();
            int fileamount = files.Length;
            int filesrenamed = 0;

            //report that the renaming is starting so the UI thread can make the 
            backgroundWorker1.ReportProgress(0, "starting");

            string filedirectory;
            string newfilepath = "";
            string filename;
            string newfilename;
            string extension;
            string regexpattern = txt_regex.Text;
            int i = 1;



            foreach (string file in files)
            {
                filedirectory = System.IO.Path.GetDirectoryName(file);
                filename = System.IO.Path.GetFileName(file);
                extension = System.IO.Path.GetExtension(file);

                if (mode == "allsame")
                {
                    newfilepath = filedirectory + "\\" + txt_newFilename.Text + "_" + i + extension;
                    
                }
                else if (mode == "regexreplace")
                {
                    Regex rgx = new Regex(regexpattern);
                    newfilename = rgx.Replace(filename, txt_replaceText.Text);
                    newfilepath = filedirectory + "\\" + newfilename+extension;
                }

                System.Threading.Thread.Sleep(1000);

                try
                {
                    System.IO.File.Move(file, newfilepath);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Something went wrong while renaming "+file+": "+error.ToString());
                }
                               
                backgroundWorker1.ReportProgress(i);

                i++;

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Array files = this.openFileDialog1.FileNames.ToArray();
            int fileamount = files.Length;
            int filesrenamed = e.ProgressPercentage;

            progbar_renameProgress.Value = filesrenamed;
            lbl_filecounter.Text = filesrenamed + "/" + fileamount;
                      
                       
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            btn_startRenaming.Enabled = true;

        }

        private void btn_startRenaming_Click(object sender, EventArgs e)
        {
            Array files = this.openFileDialog1.FileNames.ToArray();
            int fileamount = files.Length;
            int filesrenamed = 0;

            btn_startRenaming.Enabled = false;

            //set the progressbar visible
            progbar_renameProgress.Value = 0;
            progbar_renameProgress.Maximum = fileamount;
            progbar_renameProgress.Visible = true;


            //set the label next to the progressbar to display the amount of renamed files and the amount of files in total
            lbl_filecounter.Visible = true;
            lbl_filecounter.Text = 0 + "/" + fileamount;

            backgroundWorker1.RunWorkerAsync();
        }


        //make sure the new filename won't have invalid characters
        //(the next two events
        private void txt_newFilename_TextChanged(object sender, EventArgs e)
        {
            if (IsValidFileName(txt_newFilename.Text) == false)
            {
                MessageBox.Show("The filename is invalid!");
                btn_startRenaming.Enabled = false;
            }
            else
            {
                btn_startRenaming.Enabled = true;
            }
        }
           
        private void txt_replaceText_TextChanged(object sender, EventArgs e)
        {
            if (IsValidFileName(txt_replaceText.Text) == false)
            {
                MessageBox.Show("The filename is invalid!");
                btn_startRenaming.Enabled = false;
            }
            else
            {
                btn_startRenaming.Enabled = true;
            }
        }

        

        //checks if the input is a valid windows filename
        public static bool IsValidFileName(string expression, bool platformIndependent = false)
        {
            string sPattern = @"^(?!^(PRN|AUX|CLOCK\$|NUL|CON|COM\d|LPT\d|\..*)(\..+)?$)[^\x00-\x1f\\?*:\"";|/]+$";
            if (platformIndependent)
            {
                sPattern = @"^(([a-zA-Z]:|\\)\\)?(((\.)|(\.\.)|([^\\/:\*\?""\|<>\. ](([^\\/:\*\?""\|<>\. ])|([^\\/:\*\?""\|<>]*[^\\/:\*\?""\|<>\. ]))?))\\)*[^\\/:\*\?""\|<>\. ](([^\\/:\*\?""\|<>\. ])|([^\\/:\*\?""\|<>]*[^\\/:\*\?""\|<>\. ]))?$";
            }
            return (Regex.IsMatch(expression, sPattern, RegexOptions.CultureInvariant));
        }

        

        

        

        

        
                     
    }
        
}
