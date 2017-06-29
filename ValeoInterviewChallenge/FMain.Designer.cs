namespace ValeoInterviewChallenge
{
    partial class F_Main
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
            this.BT_EncryptDecrypt = new System.Windows.Forms.Button();
            this.OFD_SourceFile = new System.Windows.Forms.OpenFileDialog();
            this.SFD_TargetFile = new System.Windows.Forms.SaveFileDialog();
            this.PB_Progress = new System.Windows.Forms.ProgressBar();
            this.L_Progress = new System.Windows.Forms.Label();
            this.P_Inputs = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_PassPhrase = new System.Windows.Forms.TextBox();
            this.L_TargetFile = new System.Windows.Forms.Label();
            this.L_SourceFile = new System.Windows.Forms.Label();
            this.BT_SelectTargetFile = new System.Windows.Forms.Button();
            this.BT_SelectSourceFile = new System.Windows.Forms.Button();
            this.P_Progress = new System.Windows.Forms.Panel();
            this.P_Inputs.SuspendLayout();
            this.P_Progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_EncryptDecrypt
            // 
            this.BT_EncryptDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_EncryptDecrypt.Location = new System.Drawing.Point(11, 97);
            this.BT_EncryptDecrypt.Name = "BT_EncryptDecrypt";
            this.BT_EncryptDecrypt.Size = new System.Drawing.Size(348, 41);
            this.BT_EncryptDecrypt.TabIndex = 0;
            this.BT_EncryptDecrypt.Text = "Encrypt / Decrypt";
            this.BT_EncryptDecrypt.UseVisualStyleBackColor = true;
            this.BT_EncryptDecrypt.Click += new System.EventHandler(this.BT_EncryptDecrypt_Click);
            // 
            // OFD_SourceFile
            // 
            this.OFD_SourceFile.FileName = "openFileDialog1";
            // 
            // PB_Progress
            // 
            this.PB_Progress.Location = new System.Drawing.Point(11, 13);
            this.PB_Progress.Name = "PB_Progress";
            this.PB_Progress.Size = new System.Drawing.Size(348, 23);
            this.PB_Progress.TabIndex = 7;
            // 
            // L_Progress
            // 
            this.L_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Progress.Location = new System.Drawing.Point(11, 43);
            this.L_Progress.Name = "L_Progress";
            this.L_Progress.Size = new System.Drawing.Size(348, 17);
            this.L_Progress.TabIndex = 8;
            this.L_Progress.Text = "L_Progress";
            this.L_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Inputs
            // 
            this.P_Inputs.Controls.Add(this.label3);
            this.P_Inputs.Controls.Add(this.TB_PassPhrase);
            this.P_Inputs.Controls.Add(this.L_TargetFile);
            this.P_Inputs.Controls.Add(this.BT_EncryptDecrypt);
            this.P_Inputs.Controls.Add(this.L_SourceFile);
            this.P_Inputs.Controls.Add(this.BT_SelectTargetFile);
            this.P_Inputs.Controls.Add(this.BT_SelectSourceFile);
            this.P_Inputs.Location = new System.Drawing.Point(3, 2);
            this.P_Inputs.Name = "P_Inputs";
            this.P_Inputs.Size = new System.Drawing.Size(368, 146);
            this.P_Inputs.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pass phrase";
            // 
            // TB_PassPhrase
            // 
            this.TB_PassPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_PassPhrase.Location = new System.Drawing.Point(79, 71);
            this.TB_PassPhrase.Name = "TB_PassPhrase";
            this.TB_PassPhrase.Size = new System.Drawing.Size(280, 20);
            this.TB_PassPhrase.TabIndex = 20;
            // 
            // L_TargetFile
            // 
            this.L_TargetFile.AutoSize = true;
            this.L_TargetFile.Location = new System.Drawing.Point(112, 42);
            this.L_TargetFile.Name = "L_TargetFile";
            this.L_TargetFile.Size = new System.Drawing.Size(66, 13);
            this.L_TargetFile.TabIndex = 19;
            this.L_TargetFile.Text = "L_TargetFile";
            // 
            // L_SourceFile
            // 
            this.L_SourceFile.AutoSize = true;
            this.L_SourceFile.Location = new System.Drawing.Point(112, 14);
            this.L_SourceFile.Name = "L_SourceFile";
            this.L_SourceFile.Size = new System.Drawing.Size(69, 13);
            this.L_SourceFile.TabIndex = 18;
            this.L_SourceFile.Text = "L_SourceFile";
            // 
            // BT_SelectTargetFile
            // 
            this.BT_SelectTargetFile.Location = new System.Drawing.Point(8, 38);
            this.BT_SelectTargetFile.Name = "BT_SelectTargetFile";
            this.BT_SelectTargetFile.Size = new System.Drawing.Size(97, 23);
            this.BT_SelectTargetFile.TabIndex = 17;
            this.BT_SelectTargetFile.Text = "Select target file";
            this.BT_SelectTargetFile.UseVisualStyleBackColor = true;
            this.BT_SelectTargetFile.Click += new System.EventHandler(this.BT_SelectTargetFile_Click);
            // 
            // BT_SelectSourceFile
            // 
            this.BT_SelectSourceFile.Location = new System.Drawing.Point(8, 9);
            this.BT_SelectSourceFile.Name = "BT_SelectSourceFile";
            this.BT_SelectSourceFile.Size = new System.Drawing.Size(97, 23);
            this.BT_SelectSourceFile.TabIndex = 16;
            this.BT_SelectSourceFile.Text = "Select source file";
            this.BT_SelectSourceFile.UseVisualStyleBackColor = true;
            this.BT_SelectSourceFile.Click += new System.EventHandler(this.BT_SelectSourceFile_Click);
            // 
            // P_Progress
            // 
            this.P_Progress.Controls.Add(this.PB_Progress);
            this.P_Progress.Controls.Add(this.L_Progress);
            this.P_Progress.Location = new System.Drawing.Point(3, 150);
            this.P_Progress.Name = "P_Progress";
            this.P_Progress.Size = new System.Drawing.Size(368, 67);
            this.P_Progress.TabIndex = 10;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 218);
            this.Controls.Add(this.P_Progress);
            this.Controls.Add(this.P_Inputs);
            this.Name = "F_Main";
            this.Text = "Xor encryption tool";
            this.P_Inputs.ResumeLayout(false);
            this.P_Inputs.PerformLayout();
            this.P_Progress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_EncryptDecrypt;
        private System.Windows.Forms.OpenFileDialog OFD_SourceFile;
        private System.Windows.Forms.SaveFileDialog SFD_TargetFile;
        private System.Windows.Forms.ProgressBar PB_Progress;
        private System.Windows.Forms.Label L_Progress;
        private System.Windows.Forms.Panel P_Inputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_PassPhrase;
        private System.Windows.Forms.Label L_TargetFile;
        private System.Windows.Forms.Label L_SourceFile;
        private System.Windows.Forms.Button BT_SelectTargetFile;
        private System.Windows.Forms.Button BT_SelectSourceFile;
        private System.Windows.Forms.Panel P_Progress;
    }
}

