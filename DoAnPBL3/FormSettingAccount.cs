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
    public partial class FormSettingAccount : Form
    {
        public FormSettingAccount(string theme)
        {
            InitializeComponent();

            switch (theme)
            {
                case "Admin":
                    btnEditPassword.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    lblName.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    tbName.FillColor = Color.White;
                    tbName.BorderColor = Color.White;
                    tbPassword.FillColor = Color.White;
                    tbPassword.BorderColor = Color.White;


                    break;

                case "Dark":
                    btnEditPassword.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    lblName.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    tbName.FillColor = Color.White;
                    tbName.BorderColor = Color.White;
                    tbPassword.FillColor = Color.White;
                    tbPassword.BorderColor = Color.White;
                    break;

                case "Light":
                    btnEditPassword.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    lblName.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    tbName.FillColor = Color.White;
                    tbName.BorderColor = Color.White;
                    tbPassword.FillColor = Color.White;
                    tbPassword.BorderColor = Color.White;


                    break;
            }
        }
    }
}
