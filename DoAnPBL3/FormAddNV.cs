using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormAddNV : Form
    {
        
        //Constructor
        public FormAddNV()
        {
            InitializeComponent();
            
        }

        

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        



        

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            this.Alert("Thêm nhân viên mới thành công", Form_Alert.enmType.Success);
            this.Close();
        }
    }
}
