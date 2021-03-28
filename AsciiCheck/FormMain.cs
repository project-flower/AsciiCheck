using AsciiCheck.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AsciiCheck
{
    public partial class FormMain : Form
    {
        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            MinimumSize = Size;
            Array.ForEach(
                Resources.Encodings.Split(new string[] { Environment.NewLine }, StringSplitOptions.None),
                n => comboBoxEncodings.Items.Add(n));

            if (comboBoxEncodings.Items.Count > 0)
            {
                comboBoxEncodings.SelectedIndex = 0;
            }

            //Icon.Save(new System.IO.FileStream("AsciiCheck.ico", System.IO.FileMode.Create));
        }

        #endregion

        #region Private Methods

        private void  showErrorMessage(string message)
        {
            showMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult showMessage(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(this, text, Text, buttons, icon);
        }

        #endregion

        // Designer's Methods

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Encoding encoding;

            try
            {
                encoding = Encoding.GetEncoding(comboBoxEncodings.Text);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
                return;
            }

            string[] fileNames = textBoxFiles.Lines;

            if (fileNames.Length < 1)
            {
                return;
            }

            Dictionary<string, CheckResult[]> checkResults;

            try
            {
                checkResults = MainEngine.Check(fileNames, encoding, 100);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
                return;
            }

            var formResult = new FormResult();
            formResult.Show(checkResults, this);
        }

        private void textBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop) as string[];

            if ((data == null) || (data.Length < 1))
            {
                return;
            }

            var builder = new StringBuilder();

            if (textBoxFiles.Text.Length > 0)
            {
                textBoxFiles.Text += Environment.NewLine;
            }

            bool atFirst = true;

            foreach (string item in data)
            {
                if (atFirst)
                {
                    atFirst = false;
                }
                else
                {
                    builder.AppendLine();
                }

                builder.Append(item);
            }

            textBoxFiles.Text += builder.ToString();
        }

        private void textBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None);
        }
    }
}
