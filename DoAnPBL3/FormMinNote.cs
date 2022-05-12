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
    public partial class FormMinNote : Form
    {
        public FormMinNote()
        {
            InitializeComponent();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetTitle(string Title)
        {
            lblNoteTitle.Text = Title;
        }

        public void SetDate()
        {
            lblNoteDate.Text = DateTime.Now.ToString();
        }
    }
}
