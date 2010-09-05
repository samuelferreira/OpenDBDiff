﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBDiff.Schema.SQLServer.Options;

namespace DBDiff.Front
{
    public partial class OptionForm : Form
    {
        private SqlOption SqlFilter;

        public OptionForm()
        {
            InitializeComponent();
        }

        public void Show(IWin32Window owner, SqlOption filter)
        {
            SqlFilter = filter;
            sqlOptionsFront1.Load(filter);
            this.Show(owner);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            sqlOptionsFront1.Save();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
