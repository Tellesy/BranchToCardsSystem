﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Reports
{
    public partial class ReportsMenu : MaterialSkin.Controls.MaterialForm
    {
        public ReportsMenu()
        {
            InitializeComponent();
        }

        private void ReportsMenu_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            FromDate_DTP.CustomFormat = "yyyy-MM-dd";
            FromDate_DTP.Format = DateTimePickerFormat.Custom;
            ToDate_DTP.CustomFormat = "yyyy-MM-dd";
            ToDate_DTP.Format = DateTimePickerFormat.Custom;
        }
    }
}
