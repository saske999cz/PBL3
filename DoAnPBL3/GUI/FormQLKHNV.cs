using System;
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
    public partial class FormQLKHNV : Form
    {
        public FormQLKHNV()
        {
            InitializeComponent();
        }

        private void BtnAddKH_Click(object sender, EventArgs e)
        {
            new FormAddKH().Show();
        }
    }
}
