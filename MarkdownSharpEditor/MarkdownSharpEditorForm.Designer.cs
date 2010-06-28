namespace MarkdownEditor
{
    partial class MarkdownSharpEditorForm
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
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alternateHorizontalVerticalLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.htmlOutputTabPage = new System.Windows.Forms.TabPage();
            this.outputWebBrowser = new System.Windows.Forms.WebBrowser();
            this.rawOutputTabPage = new System.Windows.Forms.TabPage();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.outputTabControl.SuspendLayout();
            this.htmlOutputTabPage.SuspendLayout();
            this.rawOutputTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 694);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(603, 22);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(603, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alternateHorizontalVerticalLayoutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // alternateHorizontalVerticalLayoutToolStripMenuItem
            // 
            this.alternateHorizontalVerticalLayoutToolStripMenuItem.Name = "alternateHorizontalVerticalLayoutToolStripMenuItem";
            this.alternateHorizontalVerticalLayoutToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.alternateHorizontalVerticalLayoutToolStripMenuItem.Text = "Alternate Horizontal/Vertical Layout";
            this.alternateHorizontalVerticalLayoutToolStripMenuItem.Click += new System.EventHandler(this.alternateHorizontalVerticalLayoutToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.inputRichTextBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.outputTabControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(603, 670);
            this.mainSplitContainer.SplitterDistance = 371;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.AcceptsTab = true;
            this.inputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRichTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(597, 365);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged);
            // 
            // outputTabControl
            // 
            this.outputTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTabControl.Controls.Add(this.htmlOutputTabPage);
            this.outputTabControl.Controls.Add(this.rawOutputTabPage);
            this.outputTabControl.Location = new System.Drawing.Point(3, 6);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(597, 286);
            this.outputTabControl.TabIndex = 0;
            // 
            // htmlOutputTabPage
            // 
            this.htmlOutputTabPage.Controls.Add(this.outputWebBrowser);
            this.htmlOutputTabPage.Location = new System.Drawing.Point(4, 22);
            this.htmlOutputTabPage.Name = "htmlOutputTabPage";
            this.htmlOutputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.htmlOutputTabPage.Size = new System.Drawing.Size(589, 260);
            this.htmlOutputTabPage.TabIndex = 0;
            this.htmlOutputTabPage.Text = "Rendered HTML Output";
            this.htmlOutputTabPage.UseVisualStyleBackColor = true;
            // 
            // outputWebBrowser
            // 
            this.outputWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.outputWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.outputWebBrowser.Name = "outputWebBrowser";
            this.outputWebBrowser.Size = new System.Drawing.Size(589, 260);
            this.outputWebBrowser.TabIndex = 1;
            // 
            // rawOutputTabPage
            // 
            this.rawOutputTabPage.Controls.Add(this.outputRichTextBox);
            this.rawOutputTabPage.Location = new System.Drawing.Point(4, 22);
            this.rawOutputTabPage.Name = "rawOutputTabPage";
            this.rawOutputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rawOutputTabPage.Size = new System.Drawing.Size(589, 260);
            this.rawOutputTabPage.TabIndex = 1;
            this.rawOutputTabPage.Text = "Raw HTML Output";
            this.rawOutputTabPage.UseVisualStyleBackColor = true;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputRichTextBox.DetectUrls = false;
            this.outputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(589, 260);
            this.outputRichTextBox.TabIndex = 0;
            this.outputRichTextBox.Text = "";
            // 
            // MarkdownSharpEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 716);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MarkdownSharpEditorForm";
            this.Text = "Markdown Editor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.outputTabControl.ResumeLayout(false);
            this.htmlOutputTabPage.ResumeLayout(false);
            this.rawOutputTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.WebBrowser outputWebBrowser;
        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage htmlOutputTabPage;
        private System.Windows.Forms.TabPage rawOutputTabPage;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alternateHorizontalVerticalLayoutToolStripMenuItem;
    }
}

