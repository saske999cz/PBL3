using DoAnPBL3.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnPBL3
{
    public partial class FormQLNV : Form
    {
        private IconButton btnCurrent;
        public FormQLNV()
        {
            InitializeComponent();
        }


        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(34, 31, 46);
                btnCurrent.ForeColor = Color.Gainsboro;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = Color.Gainsboro;
                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                btnCurrent = (IconButton)senderBtn;
                btnCurrent.BackColor = Color.FromArgb(157, 16, 221);
                btnCurrent.ForeColor = color;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = color;
                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
            }
        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void btnAddNV_MouseEnter(object sender, EventArgs e)
        {
            btnAddNV.BackColor = RGBColors.color4;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = RGBColors.color4;
        }

        private void btnSuaNV_MouseEnter(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = RGBColors.color4;
        }

        private void btnAddNV_MouseLeave(object sender, EventArgs e)
        {
            btnAddNV.BackColor = Color.MediumSeaGreen;
        }

        private void btnDeleteNV_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = Color.Firebrick;
        }

        private void btnSuaNV_MouseLeave(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = Color.DodgerBlue;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            new FormAddNV().Show();
            //using (BookStoreContext context = new BookStoreContext())
            //{
            //    dgvQLNV.DataSource = context.Employees.Select(employee => new
            //    {
            //        employee.ID_Employee,
            //        employee.NameEmployee,
            //        employee.Gender,
            //        employee.Email,
            //        employee.Phone
            //    }).ToList();
            //}
            FormQLNV_Load(sender, e);
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            if (rjtbTKNV.Texts == "")
            {
                xuiSegmentNV.SelectedIndex = 0;
            }
            else
            {
                RJMessageBox.Show(rjtbTKNV.Texts, "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xuiSegmentNV.SelectedIndex = 0;
            }
        }

        private void rjtbTKNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnTKNV.PerformClick();
                e.Handled = true;

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblSNVNam_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvQLNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow data = dgvQLNV.CurrentRow;
            string result = "";
            result += data.Cells["ID_NhanVien"].Value.ToString()
                    + data.Cells["hoVaTen"].Value.ToString()
                    + data.Cells["SDT"].Value.ToString()
                    + data.Cells["CMND"].Value.ToString()
                    + data.Cells["diaChi"].Value.ToString();
        }

        private void dgvQLNV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                dgvQLNV.DataSource = context.Employees.Select(employee => new
                {
                    employee.ID_Employee,
                    employee.NameEmployee,
                    employee.Gender,
                    employee.Email,
                    employee.Phone
                }).ToList();
            }
        }

        private void xuiSegmentNV_Click(object sender, EventArgs e)
        {

        }
    }
}
