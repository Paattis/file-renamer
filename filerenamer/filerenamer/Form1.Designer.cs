namespace filerenamer
{
    partial class btn_selectFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_regex = new System.Windows.Forms.TextBox();
            this.lbl_regexPattern = new System.Windows.Forms.Label();
            this.txt_newFilename = new System.Windows.Forms.TextBox();
            this.lbl_newFilename = new System.Windows.Forms.Label();
            this.txt_replaceText = new System.Windows.Forms.TextBox();
            this.lbl_replaceWith = new System.Windows.Forms.Label();
            this.radio_regexPattern = new System.Windows.Forms.RadioButton();
            this.radio_newtext = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_startRenaming = new System.Windows.Forms.Button();
            this.progbar_renameProgress = new System.Windows.Forms.ProgressBar();
            this.lbl_filecounter = new System.Windows.Forms.Label();
            this.txt_selectedfiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_regex
            // 
            this.txt_regex.Location = new System.Drawing.Point(114, 277);
            this.txt_regex.Name = "txt_regex";
            this.txt_regex.Size = new System.Drawing.Size(158, 20);
            this.txt_regex.TabIndex = 2;
            this.txt_regex.Visible = false;
            // 
            // lbl_regexPattern
            // 
            this.lbl_regexPattern.Location = new System.Drawing.Point(18, 280);
            this.lbl_regexPattern.Name = "lbl_regexPattern";
            this.lbl_regexPattern.Size = new System.Drawing.Size(90, 17);
            this.lbl_regexPattern.TabIndex = 0;
            this.lbl_regexPattern.Text = "Regex:";
            this.lbl_regexPattern.Visible = false;
            // 
            // txt_newFilename
            // 
            this.txt_newFilename.Location = new System.Drawing.Point(98, 253);
            this.txt_newFilename.Name = "txt_newFilename";
            this.txt_newFilename.Size = new System.Drawing.Size(174, 20);
            this.txt_newFilename.TabIndex = 4;
            this.txt_newFilename.TextChanged += new System.EventHandler(this.txt_newFilename_TextChanged);
            // 
            // lbl_newFilename
            // 
            this.lbl_newFilename.AutoSize = true;
            this.lbl_newFilename.Location = new System.Drawing.Point(18, 256);
            this.lbl_newFilename.Name = "lbl_newFilename";
            this.lbl_newFilename.Size = new System.Drawing.Size(74, 13);
            this.lbl_newFilename.TabIndex = 5;
            this.lbl_newFilename.Text = "New filename:";
            // 
            // txt_replaceText
            // 
            this.txt_replaceText.Location = new System.Drawing.Point(114, 306);
            this.txt_replaceText.Name = "txt_replaceText";
            this.txt_replaceText.Size = new System.Drawing.Size(158, 20);
            this.txt_replaceText.TabIndex = 6;
            this.txt_replaceText.Visible = false;
            this.txt_replaceText.TextChanged += new System.EventHandler(this.txt_replaceText_TextChanged);
            // 
            // lbl_replaceWith
            // 
            this.lbl_replaceWith.AutoSize = true;
            this.lbl_replaceWith.Location = new System.Drawing.Point(18, 309);
            this.lbl_replaceWith.Name = "lbl_replaceWith";
            this.lbl_replaceWith.Size = new System.Drawing.Size(72, 13);
            this.lbl_replaceWith.TabIndex = 7;
            this.lbl_replaceWith.Text = "Replace with:";
            this.lbl_replaceWith.Visible = false;
            // 
            // radio_regexPattern
            // 
            this.radio_regexPattern.AutoSize = true;
            this.radio_regexPattern.Location = new System.Drawing.Point(21, 230);
            this.radio_regexPattern.Name = "radio_regexPattern";
            this.radio_regexPattern.Size = new System.Drawing.Size(130, 17);
            this.radio_regexPattern.TabIndex = 8;
            this.radio_regexPattern.Text = "Replace regex pattern";
            this.radio_regexPattern.UseVisualStyleBackColor = true;
            this.radio_regexPattern.CheckedChanged += new System.EventHandler(this.radio_regexPattern_CheckedChanged);
            // 
            // radio_newtext
            // 
            this.radio_newtext.AutoSize = true;
            this.radio_newtext.Checked = true;
            this.radio_newtext.Location = new System.Drawing.Point(21, 207);
            this.radio_newtext.Name = "radio_newtext";
            this.radio_newtext.Size = new System.Drawing.Size(203, 17);
            this.radio_newtext.TabIndex = 9;
            this.radio_newtext.TabStop = true;
            this.radio_newtext.Text = "Rename every file the same + number";
            this.radio_newtext.UseVisualStyleBackColor = true;
            this.radio_newtext.CheckedChanged += new System.EventHandler(this.radio_newtext_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_startRenaming
            // 
            this.btn_startRenaming.Enabled = false;
            this.btn_startRenaming.Location = new System.Drawing.Point(12, 325);
            this.btn_startRenaming.Name = "btn_startRenaming";
            this.btn_startRenaming.Size = new System.Drawing.Size(75, 23);
            this.btn_startRenaming.TabIndex = 10;
            this.btn_startRenaming.Text = "Start Renaming";
            this.btn_startRenaming.UseVisualStyleBackColor = true;
            this.btn_startRenaming.Click += new System.EventHandler(this.btn_startRenaming_Click);
            // 
            // progbar_renameProgress
            // 
            this.progbar_renameProgress.Location = new System.Drawing.Point(12, 363);
            this.progbar_renameProgress.Name = "progbar_renameProgress";
            this.progbar_renameProgress.Size = new System.Drawing.Size(201, 23);
            this.progbar_renameProgress.Step = 1;
            this.progbar_renameProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progbar_renameProgress.TabIndex = 11;
            this.progbar_renameProgress.Visible = false;
            // 
            // lbl_filecounter
            // 
            this.lbl_filecounter.AutoSize = true;
            this.lbl_filecounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filecounter.Location = new System.Drawing.Point(219, 366);
            this.lbl_filecounter.Name = "lbl_filecounter";
            this.lbl_filecounter.Size = new System.Drawing.Size(31, 20);
            this.lbl_filecounter.TabIndex = 12;
            this.lbl_filecounter.Text = "0/0";
            this.lbl_filecounter.Visible = false;
            // 
            // txt_selectedfiles
            // 
            this.txt_selectedfiles.Location = new System.Drawing.Point(12, 13);
            this.txt_selectedfiles.Multiline = true;
            this.txt_selectedfiles.Name = "txt_selectedfiles";
            this.txt_selectedfiles.ReadOnly = true;
            this.txt_selectedfiles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_selectedfiles.Size = new System.Drawing.Size(447, 148);
            this.txt_selectedfiles.TabIndex = 13;
            // 
            // btn_selectFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 394);
            this.Controls.Add(this.txt_selectedfiles);
            this.Controls.Add(this.lbl_filecounter);
            this.Controls.Add(this.progbar_renameProgress);
            this.Controls.Add(this.btn_startRenaming);
            this.Controls.Add(this.radio_newtext);
            this.Controls.Add(this.radio_regexPattern);
            this.Controls.Add(this.lbl_replaceWith);
            this.Controls.Add(this.txt_replaceText);
            this.Controls.Add(this.lbl_newFilename);
            this.Controls.Add(this.txt_newFilename);
            this.Controls.Add(this.lbl_regexPattern);
            this.Controls.Add(this.txt_regex);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "btn_selectFiles";
            this.Text = "File renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_regex;
        private System.Windows.Forms.Label lbl_regexPattern;
        private System.Windows.Forms.TextBox txt_newFilename;
        private System.Windows.Forms.Label lbl_newFilename;
        private System.Windows.Forms.TextBox txt_replaceText;
        private System.Windows.Forms.Label lbl_replaceWith;
        private System.Windows.Forms.RadioButton radio_regexPattern;
        private System.Windows.Forms.RadioButton radio_newtext;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_startRenaming;
        private System.Windows.Forms.ProgressBar progbar_renameProgress;
        private System.Windows.Forms.Label lbl_filecounter;
        private System.Windows.Forms.TextBox txt_selectedfiles;
    }
}

