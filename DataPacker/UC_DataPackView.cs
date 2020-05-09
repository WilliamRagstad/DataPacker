using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPacker
{
    public partial class UC_DataPackView : UserControl
    {
        private readonly string datapackName;
        public UC_DataPackView(string datapackName)
        {
            this.datapackName = datapackName;
            InitializeComponent();
        }

        private void UC_DataPackView_Load(object sender, EventArgs e)
        {
            label_test.Text = "Loaded: " + datapackName;
        }
    }
}
