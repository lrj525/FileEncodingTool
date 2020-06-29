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
            this.PresetSuffix = new System.Windows.Forms.TextBox();
            this.LabelPresetSuffixTip = new System.Windows.Forms.Label();
            this.CheckBoxFilterBOM = new System.Windows.Forms.CheckBox();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.excludeDir = new System.Windows.Forms.TextBox();
            this.CheckBoxFilterGbk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.Location = new System.Drawing.Point(49, 69);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(41, 12);
            this.LabelDirectory.TabIndex = 2;
            this.LabelDirectory.Text = "目录：";
            // 
            // SelectedPath
            // 
            this.SelectedPath.Location = new System.Drawing.Point(96, 65);
            this.SelectedPath.Name = "SelectedPath";
            this.SelectedPath.Size = new System.Drawing.Size(309, 21);
            this.SelectedPath.TabIndex = 3;
            this.SelectedPath.Text = "D:\\objects\\jianguo\\xsearch";
            this.SelectedPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectedPath_KeyUp);
            // 
            // FolderSelectBtn
            // 
            this.FolderSelectBtn.Location = new System.Drawing.Point(422, 64);
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
            this.LabelSuffix.Location = new System.Drawing.Point(37, 15);
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
            this.FilteredFiles.Location = new System.Drawing.Point(12, 146);
            this.FilteredFiles.Name = "FilteredFiles";
            this.FilteredFiles.Size = new System.Drawing.Size(760, 366);
            this.FilteredFiles.SmallImageList = this.ImageListIcon;
            this.FilteredFiles.TabIndex = 7;
            this.FilteredFiles.UseCompatibleStateImageBehavior = false;
            this.FilteredFiles.View = System.Windows.Forms.View.Details;
            this.FilteredFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilteredFiles_MouseDoubleClick);
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
            this.LogOutput.Location = new System.Drawing.Point(12, 524);
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.Size = new System.Drawing.Size(760, 75);
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
            // PresetSuffix
            // 
            this.PresetSuffix.Location = new System.Drawing.Point(96, 12);
            this.PresetSuffix.Name = "PresetSuffix";
            this.PresetSuffix.Size = new System.Drawing.Size(676, 21);
            this.PresetSuffix.TabIndex = 9;
            // 
            // LabelPresetSuffixTip
            // 
            this.LabelPresetSuffixTip.AutoSize = true;
            this.LabelPresetSuffixTip.Location = new System.Drawing.Point(99, 40);
            this.LabelPresetSuffixTip.Name = "LabelPresetSuffixTip";
            this.LabelPresetSuffixTip.Size = new System.Drawing.Size(125, 12);
            this.LabelPresetSuffixTip.TabIndex = 10;
            this.LabelPresetSuffixTip.Text = "多个文件后缀用｜分隔";
            // 
            // CheckBoxFilterBOM
            // 
            this.CheckBoxFilterBOM.AutoSize = true;
            this.CheckBoxFilterBOM.Location = new System.Drawing.Point(669, 67);
            this.CheckBoxFilterBOM.Name = "CheckBoxFilterBOM";
            this.CheckBoxFilterBOM.Size = new System.Drawing.Size(90, 16);
            this.CheckBoxFilterBOM.TabIndex = 11;
            this.CheckBoxFilterBOM.Text = "只显示带BOM";
            this.CheckBoxFilterBOM.UseVisualStyleBackColor = true;
            this.CheckBoxFilterBOM.CheckedChanged += new System.EventHandler(this.CheckBoxFilterBOM_CheckedChanged);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(504, 65);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ButtonRefresh.TabIndex = 12;
            this.ButtonRefresh.Text = "刷新";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "排除目录：";
            // 
            // excludeDir
            // 
            this.excludeDir.Location = new System.Drawing.Point(96, 102);
            this.excludeDir.Name = "excludeDir";
            this.excludeDir.Size = new System.Drawing.Size(309, 21);
            this.excludeDir.TabIndex = 14;
            this.excludeDir.Text = "vendor|.git|.vs";
            // 
            // CheckBoxFilterGbk
            // 
            this.CheckBoxFilterGbk.AutoSize = true;
            this.CheckBoxFilterGbk.Location = new System.Drawing.Point(669, 98);
            this.CheckBoxFilterGbk.Name = "CheckBoxFilterGbk";
            this.CheckBoxFilterGbk.Size = new System.Drawing.Size(108, 16);
            this.CheckBoxFilterGbk.TabIndex = 15;
            this.CheckBoxFilterGbk.Text = "只显示简体中文";
            this.CheckBoxFilterGbk.UseVisualStyleBackColor = true;
            this.CheckBoxFilterGbk.CheckedChanged += new System.EventHandler(this.CheckBoxFilterGbk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "仅根目录下的";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBoxFilterGbk);
            this.Controls.Add(this.excludeDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.CheckBoxFilterBOM);
            this.Controls.Add(this.LabelPresetSuffixTip);
            this.Controls.Add(this.PresetSuffix);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.FilteredFiles);
            this.Controls.Add(this.LabelSuffix);
            this.Controls.Add(this.FolderSelectBtn);
            this.Controls.Add(this.SelectedPath);
            this.Controls.Add(this.LabelDirectory);
            this.Name = "main";
            this.Text = "文件编码处理器";
            this.Load += new System.EventHandler(this.main_Load);
            this.ContextMenuStripListView.ResumeLayout(false);
            this.ContextMenuStripRichText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox PresetSuffix;
        private System.Windows.Forms.Label LabelPresetSuffixTip;
        private System.Windows.Forms.CheckBox CheckBoxFilterBOM;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox excludeDir;
        private System.Windows.Forms.CheckBox CheckBoxFilterGbk;
        private System.Windows.Forms.Label label2;
    }
}

