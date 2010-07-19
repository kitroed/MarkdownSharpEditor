using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace MarkdownEditor
{
    public partial class MarkdownSharpEditorForm : Form
    {
        MarkdownSharp.Markdown markdown = new MarkdownSharp.Markdown();

        public string FilePath { get; set; }
        public string Style
        {
            get
            { return _style; }
            set
            { _style = value; }
        }
        private string _style = "<style>html,body,table{font: normal 10pt Verdana;}li{margin-bottom:7px;}h1{font-size:18pt;}h2{font-size:14pt;}</style>";

        public MarkdownSharpEditorForm()
        {
            InitializeComponent();

            markdown.AutoHyperlink = true;
            markdown.StrictBoldItalic = true;            
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            Debug.Assert(markdown != null);

            string outputHtml = markdown.Transform(inputTextBox.Text);

            outputWebBrowser.DocumentText = Style + outputHtml;
            outputRichTextBox.Text = outputHtml;
        }

        private void alternateHorizontalVerticalLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int width = Width;
            int height = Height;



            if (mainSplitContainer.Orientation == System.Windows.Forms.Orientation.Horizontal)
            {
                Width = height;
                Height = width;

                mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            }
            else
            {
                mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;

                Width = height;
                Height = width;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
            }

            if (FilePath != null)
            {
                inputTextBox.Text = File.ReadAllText(FilePath);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if there is already a filePath, skip dialog.
            if (FilePath == null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = saveFileDialog.FileName;
                }
            }

            if (FilePath != null)
            {
                File.WriteAllText(FilePath, inputTextBox.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = FilePath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog.FileName;
            }

            if (FilePath != null)
            {
                File.WriteAllText(FilePath, inputTextBox.Text);
            }
        }

        private void reloadDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath != null)
            {
                inputTextBox.Text = File.ReadAllText(FilePath);
            }
        }
    }
}
