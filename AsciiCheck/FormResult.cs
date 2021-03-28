using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AsciiCheck
{
    public partial class FormResult : Form
    {
        #region Public Methods

        public FormResult()
        {
            InitializeComponent();
            MinimumSize = Size;
        }

        public void Show(Dictionary<string, CheckResult[]> checkResults, IWin32Window owner)
        {
            textBoxResult.Clear();

            if ((checkResults == null) || (checkResults.Count < 1))
            {
                textBoxResult.Text = "No double-byte characters were found.";
            }
            else
            {

                var builder = new StringBuilder();
                bool atFirst = true;

                foreach (KeyValuePair<string, CheckResult[]> checkResult in checkResults)
                {
                    if (atFirst)
                    {
                        atFirst = false;
                    }
                    else
                    {
                        builder.AppendLine();
                    }

                    builder.AppendLine(checkResult.Key);

                    if (checkResult.Value == null)
                    {
                        builder.AppendLine("The check failed.");
                        continue;
                    }

                    foreach (CheckResult result in checkResult.Value)
                    {
                        builder.AppendFormat("Row: {0}, Column: {1}, Text: {2}", result.Row, result.Column, result.Text);
                        builder.AppendLine();
                    }
                }

                textBoxResult.Text = builder.ToString();
            }

            textBoxResult.Select(0, 0);
            textBoxResult.Focus();
            textBoxResult.ScrollToCaret();
            buttonClose.Focus();
            ShowDialog(owner);
        }

        #endregion

        // Designer's Methods

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
