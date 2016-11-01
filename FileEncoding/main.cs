using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Utils;
using System.Threading;
using System.Threading.Tasks;

namespace FileEncodingTool
{
    public partial class main : Form
    {
        public List<string> PresetSuffix = new List<string>() { ".php", ".css", ".js", ".html", ".htm", ".txt", ".json" };        
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {            
            PresetSuffixList.DataSource = PresetSuffix;
            for (int j = 0; j < PresetSuffixList.Items.Count; j++)
                PresetSuffixList.SetItemChecked(j, true);
        }

        private async void FolderSelectBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = FolderBrowserDialogSelect.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SelectedPath.Text = FolderBrowserDialogSelect.SelectedPath;
               await processFiles(SelectedPath.Text);
            }
        }

        async Task processFiles(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                await Task.Delay(100);
                MessageBox.Show("找不到路径");
            }
            else
            {
                FilteredFiles.Items.Clear();
                await filterFile(folderPath);
            }
        }
        async Task filterFile(string folderPath)
        {

            DirectoryInfo rootInfo = new DirectoryInfo(folderPath);            
            var files = rootInfo.GetFiles("*.*", SearchOption.AllDirectories);
            List<string> suffixs = new List<string>();
            foreach (var item in PresetSuffixList.CheckedItems)
            {
                suffixs.Add(item.ToString());
            }
            var filters = files.Where(x => suffixs.Contains(x.Extension.ToLower())).ToList();
            await addToListView(filters);
        }

        async Task addToListView(List<FileInfo> files)
        {            
            foreach (var file in files)
            {
                FileEncoding fileEncoding = EncodingDetect.IsTextUTF8(file.FullName);
                if (!ImageListIcon.Images.Keys.Contains(file.Extension))
                {
                    ImageListIcon.Images.Add(file.Extension, Icon.ExtractAssociatedIcon(file.FullName));
                }
                var item = new ListViewItem();
                item.ImageIndex = ImageListIcon.Images.Keys.IndexOf(file.Extension);
                item.ToolTipText = item.Text = file.FullName;
                item.Tag = file.FullName;
                if (fileEncoding.Encoding != null)
                {
                    item.SubItems.Add(fileEncoding.Encoding.EncodingName);
                }
                else
                {
                    item.SubItems.Add("非 UTF-8");
                }
                if (fileEncoding.NoUTF8 || fileEncoding.UTF8BOM)
                {
                    item.ForeColor = Color.Red;
                }
                item.SubItems.Add(fileEncoding.UTF8BOM ? "带签名" : "");
                FilteredFiles.BeginUpdate();
                FilteredFiles.Items.Add(item);
                FilteredFiles.EndUpdate();
                FilteredFiles.Items[FilteredFiles.Items.Count - 1].EnsureVisible();
                await Task.Delay(1);
            }
        }
        private async void SelectedPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               await processFiles(SelectedPath.Text);
            }
        }


        private async void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FilteredFiles.SelectedItems)
            {
                string fileName = item.Tag as string;
                try
                {
                    string fileContent = FileReader.ReadFileContent(fileName, Encoding.UTF8);
                    FileOperator.Save(fileName, fileContent);
                    await processingLog("\r\n文件：" + fileName + "保存成功");
                }
                catch (Exception ex)
                {
                    await processingLog("\r\n文件：" + fileName + "保存失败");
                    await processingLog("\r\nError：" + ex.Message);                    
                }
                await Task.Delay(0);
            }
            await processingLog("\r\n本次操作完成--------------------------------------------------------------------------------------------------------------");
            
        }

        private async void ToolStripMenuItemRichTextClear_Click(object sender, EventArgs e)
        {
           await processingLog("", true);
        }
        async Task processingLog(string txt, bool clear = false)
        {
            if (clear)
            {
                LogOutput.Text = "";
                return;
            }
            LogOutput.Text += txt;
            await Task.Delay(0);
        }

        private void LogOutput_TextChanged(object sender, EventArgs e)
        {
            LogOutput.SelectionStart = LogOutput.Text.Length;
            LogOutput.ScrollToCaret();
        }

        private void ContextMenuStripListView_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (FilteredFiles.SelectedItems.Count <= 0) e.Cancel = true;
            ContextMenuStrip cms = (ContextMenuStrip)sender;
            var items = cms.Items.Find("Open_ToolStripMenuItem", false);
            var defItem = items.FirstOrDefault();
            int scount = FilteredFiles.SelectedItems.Count;
            if (scount > 1)
            {
                if (defItem != null)
                {
                    defItem.Visible = false;
                }
            }
            if (scount == 1)
            {
                if (defItem != null)
                {
                    defItem.Visible = true;
                }
            }
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            var selectedItem = FilteredFiles.SelectedItems[0];            
            FileView view = new FileView(selectedItem.Text);            
            view.Show();
        }
    }


}

