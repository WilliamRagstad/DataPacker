﻿using System;
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
    public partial class UC_MainMenuView : UserControl, IViewControl
    {
        public UC_MainMenuView()
        {
            InitializeComponent();
        }

        private void UC_MainMenu_Load(object sender, EventArgs e)
        {
            label_version.Text = "Version " + Settings.CurrentVersion.ToString();
        }

        public void View_OnLoad()
        {
        }

        public void View_OnUnLoad()
        {
        }
    }
}
