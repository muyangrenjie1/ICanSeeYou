namespace INCUserver
{
    partial class testform
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
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.SuspendLayout();
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(1, 45);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.Size = new System.Drawing.Size(807, 195);
            this.rtfRichTextBox1.TabIndex = 0;
            this.rtfRichTextBox1.Text = "";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 314);
            this.Controls.Add(this.rtfRichTextBox1);
            this.Name = "testform";
            this.Text = "testform";
            this.Load += new System.EventHandler(this.testform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
    }
}