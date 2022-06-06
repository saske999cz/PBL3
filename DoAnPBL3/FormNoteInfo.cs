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
    public partial class FormNoteInfo : Form
    {
        public FormNoteInfo(string title, string content)
        {
            InitializeComponent();
            tbContent.Text = content;
            tbTitle.Text = title;
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
