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

        private string filePath;

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

            outputWebBrowser.DocumentText = outputHtml;
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
                filePath = openFileDialog.FileName;
            }

            if (filePath != null)
            {
                inputTextBox.Text = File.ReadAllText(filePath);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if there is already a filePath, skip dialog.
            if (filePath == null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                }
            }

            if (filePath != null)
            {
                File.WriteAllText(filePath, inputTextBox.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = filePath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }

            if (filePath != null)
            {
                File.WriteAllText(filePath, inputTextBox.Text);
            }
        }
    }
}
