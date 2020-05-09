using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPacker
{
    public partial class Form_MainWindow : Form
    {
        private UC_MainMenuView view_mainMenu = new UC_MainMenuView();
        public Form_MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView_selectIndex(0);
        }

        public void View_Change(Control view)
        {
            panel_view.Controls.Clear();
            view.Dock = DockStyle.Fill;
            view.BackColor = Color.OldLace;
            panel_view.Controls.Add(view);
        }

        public void treeView_selectIndex(int index)
        {
            treeView_sidebar.SelectedNode = treeView_sidebar.Nodes[index];
        }

        private void treeView_sidebar_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (e.Node.Tag.Equals(Settings.treeList_tag_mainMenu)) View_Change(view_mainMenu);
                else if (e.Node.Tag.Equals(Settings.treeList_tag_dataPack)) View_Change(new UC_DataPackView(e.Node.Text));
                else MessageBox.Show("Unknown node tag!", "Unknown Tag!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
