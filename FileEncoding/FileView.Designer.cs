namespace FileEncodingTool
{
    partial class FileView
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
            this.RichTextBoxFileContent = new System.Windows.Forms.RichTextBox();
            this.MenuStripTop = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxFileContent
            // 
            this.RichTextBoxFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxFileContent.Location = new System.Drawing.Point(0, 25);
            this.RichTextBoxFileContent.Name = "RichTextBoxFileContent";
            this.RichTextBoxFileContent.Size = new System.Drawing.Size(784, 586);
            this.RichTextBoxFileContent.TabIndex = 0;
            this.RichTextBoxFileContent.Text = "";
            this.RichTextBoxFileContent.TextChanged += new System.EventHandler(this.RichTextBoxFileContent_TextChanged);
            // 
            // MenuStripTop
            // 
            this.MenuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.MenuStripTop.Location = new System.Drawing.Point(0, 0);
            this.MenuStripTop.Name = "MenuStripTop";
            this.MenuStripTop.Size = new System.Drawing.Size(784, 25);
            this.MenuStripTop.TabIndex = 1;
            this.MenuStripTop.Text = "MenuStripTop";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemClose});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(50, 21);
            this.ToolStripMenuItemFile.Text = "文件&F";
            // 
            // Save_ToolStripMenuItem
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItemSave.Text = "保存&S";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItemClose.Text = "关闭&C";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // FileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.RichTextBoxFileContent);
            this.Controls.Add(this.MenuStripTop);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStripTop;
            this.Name = "FileView";
            this.Text = "文件查看";
            this.Load += new System.EventHandler(this.FileView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileView_KeyDown);
            this.MenuStripTop.ResumeLayout(false);
            this.MenuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBoxFileContent;
        private System.Windows.Forms.MenuStrip MenuStripTop;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
    }
}