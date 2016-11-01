namespace FileEncodingTool
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.PresetSuffixList = new System.Windows.Forms.CheckedListBox();
            this.FolderBrowserDialogSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.LabelDirectory = new System.Windows.Forms.Label();
            this.SelectedPath = new System.Windows.Forms.TextBox();
            this.FolderSelectBtn = new System.Windows.Forms.Button();
            this.LabelSuffix = new System.Windows.Forms.Label();
            this.FilteredFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEncoding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutput = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStripRichText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemRichTextClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripListView.SuspendLayout();
            this.ContextMenuStripRichText.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageListIcon
            // 
            this.ImageListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageListIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PresetSuffixList
            // 
            this.PresetSuffixList.BackColor = System.Drawing.SystemColors.Menu;
            this.PresetSuffixList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PresetSuffixList.CausesValidation = false;
            this.PresetSuffixList.FormattingEnabled = true;
            this.PresetSuffixList.HorizontalScrollbar = true;
            this.PresetSuffixList.Items.AddRange(new object[] {
            ".php",
            ".css",
            ".js"});
            this.PresetSuffixList.Location = new System.Drawing.Point(71, 20);
            this.PresetSuffixList.MultiColumn = true;
            this.PresetSuffixList.Name = "PresetSuffixList";
            this.PresetSuffixList.Size = new System.Drawing.Size(401, 48);
            this.PresetSuffixList.TabIndex = 1;
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.Location = new System.Drawing.Point(12, 91);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(41, 12);
            this.LabelDirectory.TabIndex = 2;
            this.LabelDirectory.Text = "目录：";
            // 
            // SelectedPath
            // 
            this.SelectedPath.Location = new System.Drawing.Point(71, 87);
            this.SelectedPath.Name = "SelectedPath";
            this.SelectedPath.Size = new System.Drawing.Size(309, 21);
            this.SelectedPath.TabIndex = 3;
            this.SelectedPath.Text = "E:\\piwik\\config\\test";
            this.SelectedPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectedPath_KeyUp);
            // 
            // FolderSelectBtn
            // 
            this.FolderSelectBtn.Location = new System.Drawing.Point(397, 86);
            this.FolderSelectBtn.Name = "FolderSelectBtn";
            this.FolderSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.FolderSelectBtn.TabIndex = 4;
            this.FolderSelectBtn.Text = "浏览";
            this.FolderSelectBtn.UseVisualStyleBackColor = true;
            this.FolderSelectBtn.Click += new System.EventHandler(this.FolderSelectBtn_Click);
            // 
            // LabelSuffix
            // 
            this.LabelSuffix.AutoSize = true;
            this.LabelSuffix.Location = new System.Drawing.Point(14, 39);
            this.LabelSuffix.Name = "LabelSuffix";
            this.LabelSuffix.Size = new System.Drawing.Size(53, 12);
            this.LabelSuffix.TabIndex = 5;
            this.LabelSuffix.Text = "扩展名：";
            // 
            // FilteredFiles
            // 
            this.FilteredFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilteredFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderEncoding,
            this.columnHeaderBOM});
            this.FilteredFiles.ContextMenuStrip = this.ContextMenuStripListView;
            this.FilteredFiles.FullRowSelect = true;
            this.FilteredFiles.GridLines = true;
            this.FilteredFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilteredFiles.HideSelection = false;
            this.FilteredFiles.LargeImageList = this.ImageListIcon;
            this.FilteredFiles.Location = new System.Drawing.Point(12, 129);
            this.FilteredFiles.Name = "FilteredFiles";
            this.FilteredFiles.Size = new System.Drawing.Size(760, 343);
            this.FilteredFiles.SmallImageList = this.ImageListIcon;
            this.FilteredFiles.TabIndex = 7;
            this.FilteredFiles.UseCompatibleStateImageBehavior = false;
            this.FilteredFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "文件";
            this.columnHeaderFileName.Width = 507;
            // 
            // columnHeaderEncoding
            // 
            this.columnHeaderEncoding.Text = "编码格式";
            this.columnHeaderEncoding.Width = 127;
            // 
            // columnHeaderBOM
            // 
            this.columnHeaderBOM.Text = "UTF8 BOM";
            this.columnHeaderBOM.Width = 79;
            // 
            // ContextMenuStripListView
            // 
            this.ContextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemOpen});
            this.ContextMenuStripListView.Name = "ContextMenuStripListView";
            this.ContextMenuStripListView.Size = new System.Drawing.Size(191, 48);
            this.ContextMenuStripListView.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripListView_Opening);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItemSave.Text = "保存为UTF-8(无签名)";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItemOpen.Text = "打开";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // LogOutput
            // 
            this.LogOutput.ContextMenuStrip = this.ContextMenuStripRichText;
            this.LogOutput.Location = new System.Drawing.Point(12, 491);
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.Size = new System.Drawing.Size(760, 108);
            this.LogOutput.TabIndex = 8;
            this.LogOutput.Text = "";
            this.LogOutput.TextChanged += new System.EventHandler(this.LogOutput_TextChanged);
            // 
            // ContextMenuStripRichText
            // 
            this.ContextMenuStripRichText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRichTextClear});
            this.ContextMenuStripRichText.Name = "ContextMenuStripRichText";
            this.ContextMenuStripRichText.Size = new System.Drawing.Size(101, 26);
            // 
            // ToolStripMenuItemRichTextClear
            // 
            this.ToolStripMenuItemRichTextClear.Name = "ToolStripMenuItemRichTextClear";
            this.ToolStripMenuItemRichTextClear.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemRichTextClear.Text = "清空";
            this.ToolStripMenuItemRichTextClear.Click += new System.EventHandler(this.ToolStripMenuItemRichTextClear_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.FilteredFiles);
            this.Controls.Add(this.LabelSuffix);
            this.Controls.Add(this.FolderSelectBtn);
            this.Controls.Add(this.SelectedPath);
            this.Controls.Add(this.LabelDirectory);
            this.Controls.Add(this.PresetSuffixList);
            this.Name = "main";
            this.Text = "文件编码处理器";
            this.Load += new System.EventHandler(this.main_Load);
            this.ContextMenuStripListView.ResumeLayout(false);
            this.ContextMenuStripRichText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox PresetSuffixList;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogSelect;
        private System.Windows.Forms.Label LabelDirectory;
        private System.Windows.Forms.TextBox SelectedPath;
        private System.Windows.Forms.Button FolderSelectBtn;
        private System.Windows.Forms.Label LabelSuffix;
        private System.Windows.Forms.ImageList ImageListIcon;
        private System.Windows.Forms.ListView FilteredFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderEncoding;
        private System.Windows.Forms.ColumnHeader columnHeaderBOM;
        private System.Windows.Forms.RichTextBox LogOutput;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripRichText;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRichTextClear;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
    }
}

