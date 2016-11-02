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
using EncodingDelection;
using System.Diagnostics;

namespace FileEncodingTool
{
    public partial class main : Form
    {
        string presetSuffixTxt = ".php|.css|.js|.html|.htm|.txt|.json|.aspx|.cs|.asp";
        public List<ListObj> ListObj { get; set; }
        public List<ListObj> VisibleListObj { get; set; }
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            PresetSuffix.Text = presetSuffixTxt;
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
                await filterFile(folderPath);
            }
        }
        async Task filterFile(string folderPath)
        {
            
            DirectoryInfo rootInfo = new DirectoryInfo(folderPath);
            var files = rootInfo.GetFiles("*.*", SearchOption.AllDirectories);
            List<string> suffixs = PresetSuffix.Text.Split('|').ToList();
            var filters = files.Where(x => suffixs.Contains(x.Extension.ToLower())).ToList();
            ListObj = new List<ListObj>();
            VisibleListObj = new List<ListObj>();
            IdentifyEncoding identify = new EncodingDelection.IdentifyEncoding();
            var all = filters.Select(file =>
            {
                FileEncoding fileEncoding = new Utils.FileEncoding() { Encoding = Encoding.Default, NoUTF8 = true, UTF8BOM = false };
                try
                {
                    fileEncoding = identify.GetEncodingName(file);
                }
                catch (Exception ex)
                {
                    LogConsole.Log(ex.Message);
                }
                if (!ImageListIcon.Images.Keys.Contains(file.Extension))
                {
                    ImageListIcon.Images.Add(file.Extension, Icon.ExtractAssociatedIcon(file.FullName));
                }
                return new ListObj()
                {
                    Encoding = fileEncoding.Encoding,
                    FileName = file.FullName,
                    ImageIndex = ImageListIcon.Images.Keys.IndexOf(file.Extension),
                    NoUTF8 = fileEncoding.NoUTF8,
                    UTF8BOM = fileEncoding.UTF8BOM
                };

            }).ToList<ListObj>();
            CheckBoxFilterBOM.Checked = false;
            ListObj.AddRange(all);
            VisibleListObj.AddRange(all);
            await addToListView(VisibleListObj);
        }

        async Task addToListView(List<ListObj> objs)
        {
            FilteredFiles.Items.Clear();
            await Task.Delay(0);
            int count = 0;
            foreach (var obj in objs)
            {
                var item = new ListViewItem();
                item.ImageIndex = obj.ImageIndex;
                item.ToolTipText = item.Text = obj.FileName;
                item.Tag = obj.FileName;
                if (obj.Encoding != null)
                {
                    item.SubItems.Add(obj.Encoding.EncodingName);
                }
                else
                {
                    item.SubItems.Add("非UTF8或不明确");
                }
                if (obj.NoUTF8 || obj.UTF8BOM)
                {
                    item.ForeColor = Color.Red;
                }
                item.SubItems.Add(obj.UTF8BOM ? "带签名" : "");
                FilteredFiles.BeginUpdate();
                FilteredFiles.Items.Add(item);
                FilteredFiles.EndUpdate();
                FilteredFiles.Items[FilteredFiles.Items.Count - 1].EnsureVisible();
                count++;
                if (count % 20 == 0)
                {
                   await Task.Delay(1);
                }
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

        private void FilteredFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = FilteredFiles.FocusedItem;
            FileView view = new FileView(selectedItem.Text);
            view.Show();
        }

        private async void CheckBoxFilterBOM_CheckedChanged(object sender, EventArgs e)
        {
            VisibleListObj.Clear();

            if (CheckBoxFilterBOM.Checked)
            {
                VisibleListObj.AddRange(ListObj.Where(x => x.UTF8BOM).ToList());
            }
            else
            {
                VisibleListObj.AddRange(ListObj);
            }
            await addToListView(VisibleListObj);
        }

        private async void ButtonRefresh_Click(object sender, EventArgs e)
        {
            await processFiles(SelectedPath.Text);
        }
    }

    public class ListObj
    {
        public string FileName { get; set; }
        public Encoding Encoding { get; set; }
        public bool UTF8BOM { get; set; }
        public bool NoUTF8 { get; set; }
        public int ImageIndex { get; set; }
    }

}

