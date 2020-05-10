using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPacker
{
    public partial class Form_MainWindow : Form
    {
        public static Form_MainWindow Instance;

        private TreeNode treeNode_mainMenu = new TreeNode("Main Menu", 5, 5);
        private TreeNode treeNode_dataPacks = new TreeNode("Data Packs", 6, 6);
        private TreeNode treeNode_worlds = new TreeNode("Worlds", 7, 7);

        public UC_MainMenuView view_mainMenu = new UC_MainMenuView();
        public Dictionary<string, UC_DataPackView> views_dataPacks = new Dictionary<string, UC_DataPackView>();
        public Form_MainWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadUI();
            setupFolderStructure();
            loadDataPacks();
            loadWorlds();
        }

        private void setupFolderStructure()
        {
            if (!Directory.Exists(Settings.HomeFolder)) Directory.CreateDirectory(Settings.HomeFolder);
            if (!Directory.Exists(Settings.DataPacksFolder)) Directory.CreateDirectory(Settings.DataPacksFolder);
        }

        private void loadUI()
        {
            treeNode_mainMenu.Name = "Node_mainMenu";
            treeNode_mainMenu.Tag = "mainmenu";
            treeNode_mainMenu.ToolTipText = "Start screen";

            treeNode_dataPacks.Name = "Node_dataPacks";
            treeNode_worlds.ToolTipText = "Your saved datapacks";

            treeNode_worlds.Name = "Node_worlds";
            treeNode_worlds.ToolTipText = "Your Minecraft worlds";

            treeView_sidebar.Nodes.Clear();
            treeView_sidebar.Nodes.AddRange(new TreeNode[] {
                treeNode_mainMenu,
                treeNode_dataPacks,
                treeNode_worlds
            });

            treeView_selectIndex(0);
        }

        public void View_Change(IViewControl viewable)
        {
            if (panel_view.Controls.Count > 0)
            {
                if (panel_view.Controls[0] is IViewControl) (panel_view.Controls[0] as IViewControl).View_OnUnLoad();
            }

            UserControl view = viewable as UserControl;
            panel_view.Controls.Clear();
            view.Dock = DockStyle.Fill;
            view.BackColor = Color.OldLace;
            panel_view.Controls.Add(view);

            viewable.View_OnLoad();
        }

        public void treeView_selectIndex(int index)
        {
            treeView_sidebar.SelectedNode = treeView_sidebar.Nodes[index];
        }

        private void treeView_sidebar_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (e.Node.Tag.Equals(Settings.TreeList_tag_mainMenu)) View_Change(view_mainMenu);
                else if (e.Node.Tag.Equals(Settings.TreeList_tag_dataPack))
                {
                    UC_DataPackView view;
                    if (views_dataPacks.ContainsKey(e.Node.Text)) view = views_dataPacks[e.Node.Text];
                    else
                    {
                        view = new UC_DataPackView(e.Node.Text, e.Node);
                        views_dataPacks.Add(e.Node.Text, view);
                    }
                    View_Change(view);
                }
                else if (e.Node.Tag.Equals(Settings.TreeList_tag_world))
                {
                    throw new NotImplementedException();
                }
                else MessageBox.Show("Unknown node tag!", "Unknown Tag!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView_addDataPack(string name)
        {
            TreeNode node = new TreeNode();
            node.Name = "Node_datapack_" + name.Replace(" ", "").ToLower();
            node.Text = name;
            node.Tag = Settings.TreeList_tag_dataPack;
            node.ImageIndex = 0;
            node.SelectedImageIndex = 0;

            treeNode_dataPacks.Nodes.Add(node);
        }

        private void loadDataPacks()
        {
            string[] datapacks = Directory.GetDirectories(Settings.DataPacksFolder);
            foreach (string datapack in datapacks)
            {
                string name = Path.GetFileName(datapack);
                treeView_addDataPack(name);
            }
        }

        private void treeView_addWorld(string name)
        {
            TreeNode node = new TreeNode();
            node.Name = "Node_world_" + name.Replace(" ", "").ToLower();
            node.Text = name;
            node.Tag = Settings.TreeList_tag_world;
            node.ImageIndex = 8;
            node.SelectedImageIndex = 8;

            treeNode_worlds.Nodes.Add(node);
        }

        private void loadWorlds()
        {
            string[] worlds = Directory.GetDirectories(Settings.WorldsFolder);
            foreach (string world in worlds)
            {
                string name = Path.GetFileName(world);
                treeView_addWorld(name);
            }
        }

        private void visitWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WilliamRagstad/DataPacker/wiki");
        }
    }
}
