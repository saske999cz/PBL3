﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormQLS : Form
    {
        public FormQLS()
        {
            InitializeComponent();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            new FormAddSach().Show();
        }
    }
}
