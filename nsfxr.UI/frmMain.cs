﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nsfxr.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void valueSlider1_ValueUpdated(object sender, EventArgs args)
        {
            Text = valueSlider1.Value.ToString();
        }
    }
}