namespace DataPacker
{
    partial class Form_MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_view = new System.Windows.Forms.Panel();
            this.treeView_sidebar = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer_mainWindow = new System.Windows.Forms.SplitContainer();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_mainWindow)).BeginInit();
            this.splitContainer_mainWindow.Panel1.SuspendLayout();
            this.splitContainer_mainWindow.Panel2.SuspendLayout();
            this.splitContainer_mainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel_view
            // 
            this.panel_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_view.Location = new System.Drawing.Point(0, 0);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(438, 316);
            this.panel_view.TabIndex = 4;
            // 
            // treeView_sidebar
            // 
            this.treeView_sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_sidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_sidebar.ImageIndex = 0;
            this.treeView_sidebar.ImageList = this.imageList1;
            this.treeView_sidebar.Location = new System.Drawing.Point(0, 0);
            this.treeView_sidebar.Name = "treeView_sidebar";
            this.treeView_sidebar.SelectedImageIndex = 0;
            this.treeView_sidebar.Size = new System.Drawing.Size(184, 316);
            this.treeView_sidebar.TabIndex = 5;
            this.treeView_sidebar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_sidebar_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "commandblocks.png");
            this.imageList1.Images.SetKeyName(1, "editor_icon.png");
            this.imageList1.Images.SetKeyName(2, "export_icon.png");
            this.imageList1.Images.SetKeyName(3, "file_icon.png");
            this.imageList1.Images.SetKeyName(4, "import_icon.png");
            this.imageList1.Images.SetKeyName(5, "logo_small.png");
            this.imageList1.Images.SetKeyName(6, "my_datapacks_icon.png");
            this.imageList1.Images.SetKeyName(7, "worlds_icon.png");
            this.imageList1.Images.SetKeyName(8, "grass.png");
            // 
            // splitContainer_mainWindow
            // 
            this.splitContainer_mainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_mainWindow.Location = new System.Drawing.Point(0, 24);
            this.splitContainer_mainWindow.Name = "splitContainer_mainWindow";
            // 
            // splitContainer_mainWindow.Panel1
            // 
            this.splitContainer_mainWindow.Panel1.Controls.Add(this.treeView_sidebar);
            this.splitContainer_mainWindow.Panel1MinSize = 10;
            // 
            // splitContainer_mainWindow.Panel2
            // 
            this.splitContainer_mainWindow.Panel2.Controls.Add(this.panel_view);
            this.splitContainer_mainWindow.Panel2MinSize = 96;
            this.splitContainer_mainWindow.Size = new System.Drawing.Size(623, 316);
            this.splitContainer_mainWindow.SplitterDistance = 184;
            this.splitContainer_mainWindow.SplitterWidth = 1;
            this.splitContainer_mainWindow.TabIndex = 6;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitWikiToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // visitWikiToolStripMenuItem
            // 
            this.visitWikiToolStripMenuItem.Name = "visitWikiToolStripMenuItem";
            this.visitWikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visitWikiToolStripMenuItem.Text = "DataPacker Wiki";
            this.visitWikiToolStripMenuItem.Click += new System.EventHandler(this.visitWikiToolStripMenuItem_Click);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.splitContainer_mainWindow);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(580, 300);
            this.Name = "Form_MainWindow";
            this.Text = "DataPacker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer_mainWindow.Panel1.ResumeLayout(false);
            this.splitContainer_mainWindow.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_mainWindow)).EndInit();
            this.splitContainer_mainWindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.TreeView treeView_sidebar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer_mainWindow;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
    }
}

