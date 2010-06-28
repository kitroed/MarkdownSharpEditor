using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MarkdownEditor
{
    public partial class MarkdownSharpEditorForm : Form
    {
        MarkdownSharp.Markdown markdown = new MarkdownSharp.Markdown();

        public MarkdownSharpEditorForm()
        {
            InitializeComponent();

            markdown.AutoHyperlink = true;
            markdown.StrictBoldItalic = true;            
        }

        private void inputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            Debug.Assert(markdown != null);

            string outputHtml = markdown.Transform(inputRichTextBox.Text);

            outputWebBrowser.DocumentText = outputHtml;
            outputRichTextBox.Text = outputHtml;
        }

        private void alternateHorizontalVerticalLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int width = Width;
            int height = Height;

            Width = height;
            Height = width;

            if (mainSplitContainer.Orientation == System.Windows.Forms.Orientation.Horizontal)
            {
                mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            }
            else
            {
                mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            }
        }
    }
}
