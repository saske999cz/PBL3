﻿using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormQLNV : Form
    {
        private IconButton btnCurrent;
        private readonly string accountUsername;
        private readonly string password;
        private readonly string theme;

        public FormQLNV(string theme, string accountUsername, string password)
        {
            InitializeComponent();
            this.theme = theme;
            this.accountUsername = accountUsername;
            this.password = password;
            switch (theme)
            {
                case "Admin":
                    btnAddNV.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTSNV.ForeColor = Color.White;
                    lblSNVNu.ForeColor = Color.White;
                    lblSNVNam.ForeColor = Color.White;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKNV.BackColor = Color.FromArgb(23, 21, 35);
                    rjtbTKNV.BorderColor = Color.FromArgb(23, 21, 35);
                    rjtbTKNV.ForeColor = Color.Silver;
                    rjtbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLNV.BackgroundColor = Color.FromArgb(24, 37, 65);
                    break;
                case "Dark":
                    btnAddNV.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    btnAddNV.Parent.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTSNV.ForeColor = Color.White;
                    lblSNVNu.ForeColor = Color.White;
                    lblSNVNam.ForeColor = Color.White;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKNV.BackColor = Color.FromArgb(18, 18, 18);
                    rjtbTKNV.BorderColor = Color.FromArgb(18, 18, 18);
                    rjtbTKNV.ForeColor = Color.Silver;
                    rjtbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLNV.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    btnAddNV.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    btnAddNV.Parent.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    label2.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    lblTSNV.ForeColor = Color.Black;
                    lblSNVNu.ForeColor = Color.Black;
                    lblSNVNam.ForeColor = Color.Black;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKNV.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKNV.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKNV.ForeColor = Color.DimGray;
                    rjtbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLNV.BackgroundColor = Color.Silver;
                    break;
            }
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

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void BtnAddNV_MouseEnter(object sender, EventArgs e)
        {
            btnAddNV.BackColor = RGBColors.color4;
        }

        private void IconButton1_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = RGBColors.color4;
        }

        private void BtnEditNV_MouseEnter(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = RGBColors.color4;
        }

        private void BtnAddNV_MouseLeave(object sender, EventArgs e)
        {
            btnAddNV.BackColor = Color.MediumSeaGreen;
        }

        private void BtnDeleteNV_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = Color.Firebrick;
        }

        private void BtnEditNV_MouseLeave(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = Color.DodgerBlue;
        }

        private void BtnEmployeeQuitJob_MouseEnter(object sender, EventArgs e)
        {
            btnEmployeeQuitJob.BackColor = RGBColors.color4;
        }

        private void BtnEmployeeQuitJob_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeQuitJob.BackColor = Color.MidnightBlue;
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void BtnNam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void BtnNu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            dgvQLNV.RowHeadersVisible = true;
            dgvQLNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            using (BookStoreContext context = new BookStoreContext())
            {
                var listEmployees = context.Employees
                    .Where(employee => employee.AccountUsername != null)
                    .Select(employee => new
                    {
                        employee.ID_Employee,
                        employee.FullNameEmployee,
                        employee.Gender,
                        employee.Email,
                        employee.Phone,
                    });
                var listMaleEmployees = listEmployees.Where(employee => employee.Gender == "Nam");
                var listFemaleEmployees = listEmployees.Where(employee => employee.Gender == "Nữ");
                dgvQLNV.DataSource = listEmployees.ToList();
                label2.Text = "Tổng số nhân viên làm việc";
                lblTSNV.Text = listEmployees.Count().ToString();
                lblSNVNam.Text = listMaleEmployees.Count().ToString();
                lblSNVNu.Text = listFemaleEmployees.Count().ToString();
            }
        }

        private void BtnAddNV_Click(object sender, EventArgs e)
        {
            FormAddNV formAddNV = new FormAddNV(theme);
            formAddNV.RefreshData += new FormAddNV.LoadData(FormQLNV_Load);
            formAddNV.ShowDialog();
        }

        private void BtnEditNV_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow == null)
            {
                RJMessageBox.Show("Hệ thống chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID_Employee = dgvQLNV.CurrentRow.Cells["ID_Employee"].Value.ToString();
                FormSuaNV formSuaNV = new FormSuaNV(theme, ID_Employee);
                formSuaNV.RefreshData += new FormSuaNV.LoadData(FormQLNV_Load);
                formSuaNV.ShowDialog();
            }
        }

        private void BtnDeleteNV_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow == null)
            {
                RJMessageBox.Show("Hệ thống chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID_Employee = dgvQLNV.CurrentRow.Cells["ID_Employee"].Value.ToString();
                string name = dgvQLNV.CurrentRow.Cells["FullNameEmployee"].Value.ToString();
                DialogResult result = RJMessageBox.Show("Xác nhận xóa nhân viên " + name + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormIdentify formIdentify = new FormIdentify(accountUsername, password, ID_Employee);
                    formIdentify.RefreshData += new FormIdentify.LoadData(FormQLNV_Load);
                    formIdentify.Show();
                }
                else
                    return;
            }
        }

        private void BtnEmployeeQuitJob_Click(object sender, EventArgs e)
        {
            dgvQLNV.RowHeadersVisible = true;
            dgvQLNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            using (BookStoreContext context = new BookStoreContext())
            {
                var listEmployeesQuitJob = context.Employees
                    .Where(employee => employee.AccountUsername == null)
                    .Select(employee => new
                    {
                        employee.ID_Employee,
                        employee.FullNameEmployee,
                        employee.Gender,
                        employee.Email,
                        employee.Phone,
                    });
                var listMaleEmployees = listEmployeesQuitJob.Where(employee => employee.Gender == "Nam");
                var listFemaleEmployees = listEmployeesQuitJob.Where(employee => employee.Gender == "Nữ");
                label2.Text = "Tổng số nhân viên nghỉ việc";
                dgvQLNV.DataSource = listEmployeesQuitJob.ToList();
                lblTSNV.Text = listEmployeesQuitJob.Count().ToString();
                lblSNVNam.Text = listMaleEmployees.Count().ToString();
                lblSNVNu.Text = listFemaleEmployees.Count().ToString();
            }
        }

        private void DgvQLNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Employee = dgvQLNV.CurrentRow.Cells["ID_Employee"].Value.ToString();
            new FormTTNV(theme, ID_Employee).ShowDialog();
        }

        private void BtnTKNV_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (rjtbTKNV.Texts.Trim() == "")
                {
                    RJMessageBox.Show("Vui lòng điền thông tin nhân viên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Validators.IsValidPhoneNumber(rjtbTKNV.Texts, Validators.PHONE_REGEX))
                {
                    var listEmployees = context.Employees
                        .Where(employee => employee.Phone == rjtbTKNV.Texts)
                        .Select(employee => new
                        {
                            employee.ID_Employee,
                            employee.FullNameEmployee,
                            employee.Gender,
                            employee.Email,
                            employee.Phone
                        })
                        .ToList();
                    if (listEmployees.Count == 0)
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dgvQLNV.DataSource = listEmployees;
                }
                else
                {
                    var listEmployees = context.Employees
                        .Where(employee => employee.FullNameEmployee.Contains(rjtbTKNV.Texts))
                        .Select(employee => new
                        {
                            employee.ID_Employee,
                            employee.FullNameEmployee,
                            employee.Gender,
                            employee.Email,
                            employee.Phone
                        })
                        .ToList();
                    if (listEmployees.Count == 0)
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dgvQLNV.DataSource = listEmployees;
                }
            }
        }

        private void RjtbTKNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKNV.PerformClick();
                e.Handled = true;
            }
        }

        private void XuiSegmentNV_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listEmployees = context.Employees
                        .Where(employee => employee.AccountUsername != null)
                        .Select(employee => new
                        {
                            employee.ID_Employee,
                            employee.FullNameEmployee,
                            employee.Gender,
                            employee.Email,
                            employee.Phone
                        })
                        .ToList();
                label2.Text = "Tổng số nhân viên làm việc";
                var listMaleEmployees = listEmployees.Where(employee => employee.Gender == "Nam").ToList();
                var listFemaleEmployees = listEmployees.Where(employee => employee.Gender == "Nữ").ToList();
                lblTSNV.Text = listEmployees.Count().ToString();
                lblSNVNam.Text = listMaleEmployees.Count().ToString();
                lblSNVNu.Text = listFemaleEmployees.Count().ToString();
                // Tất cả
                if (xuiSegmentNV.SelectedIndex == 0)
                    dgvQLNV.DataSource = listEmployees;
                // Nam
                else if (xuiSegmentNV.SelectedIndex == 1)
                    dgvQLNV.DataSource = listMaleEmployees;
                // Nữ
                else
                    dgvQLNV.DataSource = listFemaleEmployees;
            }
        }
    }
}