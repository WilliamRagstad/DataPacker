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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Main Menu");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Test 1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Data Packs", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_view = new System.Windows.Forms.Panel();
            this.treeView_sidebar = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel_view
            // 
            this.panel_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_view.Location = new System.Drawing.Point(168, 24);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(453, 314);
            this.panel_view.TabIndex = 4;
            // 
            // treeView_sidebar
            // 
            this.treeView_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_sidebar.Location = new System.Drawing.Point(0, 24);
            this.treeView_sidebar.Name = "treeView_sidebar";
            treeNode1.Name = "Node_mainMenu";
            treeNode1.Tag = Settings.treeList_tag_mainMenu;
            treeNode1.Text = "Main Menu";
            treeNode1.ToolTipText = "Show the start screen";
            treeNode2.Name = "Node_datapack_test1";
            treeNode2.Tag = Settings.treeList_tag_dataPack;
            treeNode2.Text = "Test 1";
            treeNode3.Name = "Node_dataPacks";
            treeNode3.Text = "Data Packs";
            this.treeView_sidebar.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            this.treeView_sidebar.Size = new System.Drawing.Size(162, 316);
            this.treeView_sidebar.TabIndex = 5;
            this.treeView_sidebar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_sidebar_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.treeView_sidebar);
            this.Controls.Add(this.panel_view);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(580, 300);
            this.Name = "Form1";
            this.Text = "DataPacker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.TreeView treeView_sidebar;
    }
}

