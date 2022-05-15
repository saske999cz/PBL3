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
    public partial class FormTTS : Form
    {
        public FormTTS()
        {
            InitializeComponent();
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
