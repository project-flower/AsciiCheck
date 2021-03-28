
namespace AsciiCheck
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFiles = new System.Windows.Forms.Label();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.labelEncodings = new System.Windows.Forms.Label();
            this.comboBoxEncodings = new System.Windows.Forms.ComboBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(12, 9);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(26, 12);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "&File:";
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.AllowDrop = true;
            this.textBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiles.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFiles.Location = new System.Drawing.Point(12, 24);
            this.textBoxFiles.Multiline = true;
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFiles.Size = new System.Drawing.Size(776, 385);
            this.textBoxFiles.TabIndex = 1;
            this.textBoxFiles.WordWrap = false;
            this.textBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFiles_DragDrop);
            this.textBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFiles_DragEnter);
            // 
            // labelEncodings
            // 
            this.labelEncodings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEncodings.AutoSize = true;
            this.labelEncodings.Location = new System.Drawing.Point(12, 420);
            this.labelEncodings.Name = "labelEncodings";
            this.labelEncodings.Size = new System.Drawing.Size(53, 12);
            this.labelEncodings.TabIndex = 2;
            this.labelEncodings.Text = "&Encoding:";
            // 
            // comboBoxEncodings
            // 
            this.comboBoxEncodings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEncodings.FormattingEnabled = true;
            this.comboBoxEncodings.Location = new System.Drawing.Point(71, 417);
            this.comboBoxEncodings.Name = "comboBoxEncodings";
            this.comboBoxEncodings.Size = new System.Drawing.Size(121, 20);
            this.comboBoxEncodings.TabIndex = 3;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Location = new System.Drawing.Point(713, 415);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "&Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.comboBoxEncodings);
            this.Controls.Add(this.labelEncodings);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.labelFiles);
            this.Name = "FormMain";
            this.Text = "AsciiCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.TextBox textBoxFiles;
        private System.Windows.Forms.Label labelEncodings;
        private System.Windows.Forms.ComboBox comboBoxEncodings;
        private System.Windows.Forms.Button buttonCheck;
    }
}

