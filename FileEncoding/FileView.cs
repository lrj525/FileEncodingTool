using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace FileEncodingTool
{
    public partial class FileView : Form
    {
        public string FileName { get; set; }  
        public string PreviousContent { get; set; }
        public RichTextBoxFileContentFlag richTextBoxFileContentFlag;
        public FileView()
        {
            InitializeComponent();
        }
        public FileView(string fileName) {
            FileName = fileName;
           
            InitializeComponent();
        }

        private void FileView_Load(object sender, EventArgs e)
        {
            string fileContent = FileReader.ReadFileContent(FileName, Encoding.UTF8);
            RichTextBoxFileContent.Tag = true;
            RichTextBoxFileContent.Text =  fileContent;
            PreviousContent = RichTextBoxFileContent.Text;
            this.Text = FileName;
        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileOperator.Save(FileName, RichTextBoxFileContent.Text);
                PreviousContent = RichTextBoxFileContent.Text;
                this.Text = FileName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)

            {
                try
                {
                    FileOperator.Save(FileName, RichTextBoxFileContent.Text);
                    PreviousContent = RichTextBoxFileContent.Text;
                    this.Text = FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void RichTextBoxFileContent_TextChanged(object sender, EventArgs e)
        {
            if ((bool)RichTextBoxFileContent.Tag)
            {
                RichTextBoxFileContent.Tag = false;
                return;
            }
            if (PreviousContent != RichTextBoxFileContent.Text)
            {
                this.Text = "*" + FileName;
            }
        }
        public class RichTextBoxFileContentFlag
        {
            public bool ContentChanged { get; set; }
        }
    }
}
