using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValeoInterviewChallenge.CryptographyService.Interface;

namespace ValeoInterviewChallenge
{
    public partial class F_Main : Form
    {
        private ICryptographyService _cryptographyService;
        private Progress<double> _progress;

        /// <summary>
        /// Initializes a new instance of the <see cref="F_Main"/> class.
        /// 
        /// This costructor is here just for designer / do not use it!
        /// </summary>
        public F_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="F_Main"/> class.
        /// </summary>
        /// <param name="cryptographyService">The cryptography service.</param>
        public F_Main(ICryptographyService cryptographyService)
        {
            _cryptographyService = cryptographyService;
            _progress = new Progress<double>(HandleProgressChange);
            InitializeComponent();
            SetUIReady();
        }

        /// <summary>
        /// Handles the Click event of the BT_SelectSourceFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BT_SelectSourceFile_Click(object sender, EventArgs e)
        {
            switch(OFD_SourceFile.ShowDialog(this))
            {
                case DialogResult.OK:
                    L_SourceFile.Text = GetShortFileName(OFD_SourceFile.FileName);
                    break;
            }

        }

        /// <summary>
        /// Handles the Click event of the BT_SelectTargetFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BT_SelectTargetFile_Click(object sender, EventArgs e)
        {
            switch (SFD_TargetFile.ShowDialog(this))
            {
                case DialogResult.OK:
                    L_TargetFile.Text = GetShortFileName(SFD_TargetFile.FileName);
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the BT_EncryptDecrypt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void BT_EncryptDecrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            SetUIEncryptionInProgress();
            try
            {
                using (var sourceFileStream = OFD_SourceFile.OpenFile())
                {
                    using (var targetFileStream = SFD_TargetFile.OpenFile())
                    {
                        //using ICryptographyService.DecryptStreamAsync method only as the task is to use xor for encryption and decryption, but the ICryptographyService is designed more universaly
                        await _cryptographyService.DecryptStreamAsync(sourceFileStream, targetFileStream, TB_PassPhrase.Text, _progress);
                        await targetFileStream.FlushAsync();
                    }
                }
                MessageBox.Show(this, "Encryption / decryption finished");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to encrypt / decrypt file.\n\nMessage:{ex.Message}");
            }
            SetUIReady();
        }

        /// <summary>
        /// Validates user inputs.
        /// </summary>
        private bool ValidateInputs()
        {
            if(!OFD_SourceFile.CheckFileExists || string.IsNullOrEmpty(OFD_SourceFile.FileName))
            {
                ShowErrorInputMessage("Please select source file");
                return false;
            }
            if (!SFD_TargetFile.CheckPathExists || string.IsNullOrEmpty(SFD_TargetFile.FileName))
            {
                ShowErrorInputMessage("Please select target file and path");
                return false;
            }

            if (string.IsNullOrEmpty(TB_PassPhrase.Text))
            {
                ShowErrorInputMessage("Please enter pass phrase");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Shows the error input message.
        /// </summary>
        /// <param name="message">The message.</param>
        private void ShowErrorInputMessage(string message)
        {
            MessageBox.Show(this, message, "Input required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Sets the UI into ready state.
        /// </summary>
        private void SetUIReady()
        {
            P_Inputs.Enabled = true;
            L_SourceFile.Text = "";
            OFD_SourceFile.Reset();
            L_TargetFile.Text = "";
            SFD_TargetFile.Reset();
            P_Progress.Visible = false;
        }

        /// <summary>
        /// Sets the UI into progress state.
        /// </summary>
        private void SetUIEncryptionInProgress()
        {
            P_Inputs.Enabled = false;
            PB_Progress.Value = 0;
            L_Progress.Text = "0% done";
            P_Progress.Visible = true;
        }

        /// <summary>
        /// Gets the short name of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private string GetShortFileName(string filePath)
        {
            return (new FileInfo(filePath)).Name;
        }

        /// <summary>
        /// Handles the progress change.
        /// </summary>
        /// <param name="percentage">The percentage.</param>
        private void HandleProgressChange(double percentage)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => HandleProgressChange(percentage)));
            }
            else
            {
                int roundedPercentage = (int)Math.Round(percentage, 0);
                PB_Progress.Value = roundedPercentage;
                L_Progress.Text = $"{roundedPercentage}% done";
            }
        }
    }
}
