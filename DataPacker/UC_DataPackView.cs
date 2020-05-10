using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataPacker.Models.MCMeta;
using Newtonsoft.Json;

namespace DataPacker
{
    public partial class UC_DataPackView : UserControl, IViewControl
    {
        private readonly string datapackName;
        private MCMeta meta;
        private readonly TreeNode node;
        public UC_DataPackView(string datapackName, TreeNode node)
        {
            this.datapackName = datapackName;
            this.node = node;

            InitializeComponent();

            loadDataPack();
        }

        private void UC_DataPackView_Load(object sender, EventArgs e)
        {
            label_title.Text = datapackName;
            label_author.Text = "";
            label_version.Text = "";
            richTextBox_description.Text = "";

            loadMeta();
        }

        private void loadDataPack()
        {
            string datapackFolder = Path.Combine(Settings.DataPacksFolder, datapackName);
            if (Directory.Exists(datapackFolder))
            {
                string datapackThumbnail = Path.Combine(datapackFolder, Settings.DataPack_thumbnail);
                string datapackMeta = Path.Combine(datapackFolder, Settings.DataPack_meta);

                if (File.Exists(datapackThumbnail))
                {
                    Image thumbnail = Image.FromFile(datapackThumbnail);
                    pictureBox_thumbnail.BackgroundImage = thumbnail;
                }

                if (File.Exists(datapackMeta))
                {
                    try
                    {
                        meta = JsonConvert.DeserializeObject<MCMeta>(File.ReadAllText(datapackMeta));
                        loadMeta();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Could not load datapack metadata! JSON was corrupted...", "Failed to load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not load selected datapack! The folder could not be found...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form_MainWindow.Instance.View_Change((IViewControl)Form_MainWindow.Instance.view_mainMenu);
            }
        }

        private void loadMeta()
        {
            if (meta.datapacker != null)
            {
                if (meta.datapacker.title != null) label_title.Text = meta.datapacker.title;
                if (meta.datapacker.author != null) label_author.Text = "By " + meta.datapacker.author;
                else
                {
                    richTextBox_description.Location = label_author.Location;
                    richTextBox_description.Size = new Size(richTextBox_description.Size.Width, richTextBox_description.Size.Height + label_author.Size.Height - 3);
                }
                if (meta.datapacker.version != null) label_version.Text = "Version " + meta.datapacker.version;
            }
            if (meta.pack != null)
            {
                if (meta.pack.description != null) richTextBox_description.Text = meta.pack.description;
            }
        }

        public void View_OnLoad()
        {
            // node.Text = datapackName + " (selected)";
        }

        public void View_OnUnLoad()
        {
            // node.Text = datapackName;
        }
    }
}
