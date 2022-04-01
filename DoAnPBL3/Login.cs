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
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        BookStoreContext BookStore;

        private void Login_Load(object sender, EventArgs e)
        {
            BookStore = new BookStoreContext();
            BookStore.Languages.ToList();
            MessageBox.Show("Đã tạo DB thành công");
        }
    }
}