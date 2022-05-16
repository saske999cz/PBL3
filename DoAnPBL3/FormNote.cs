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
        private int index;
        public FormNote()
        {
            InitializeComponent();
            this.Text = "Ghi chú";
            
        }

        public string GetTitle()
        {
            return tbTitle.Text;
        }

        public string GetContent()
        {
            return tbContent.Text;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            rjbtnOK.Parent.Parent.Text = "Changed";
            this.Hide();
            this.Alert("Đã thêm ghi chú mới", Form_Alert.enmType.Success);
           
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
