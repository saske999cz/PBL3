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
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
            Text = "Ghi chú";
        }

        public string GetTitle()
        {
            return tbTitle.Text;
        }

        public string GetContent()
        {
            return tbContent.Text;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            rjbtnOK.Parent.Parent.Text = "Changed";
            Hide();
            Alert("Đã thêm ghi chú mới", Form_Alert.EnmType.Success);
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
