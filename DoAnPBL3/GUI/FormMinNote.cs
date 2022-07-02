using DoAnPBL3.BLL;
using DoAnPBL3.Models;
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
        private string content;
        private string theme;
        private string id;
        public FormMinNote(string theme, string id)
        {
            this.theme = theme;
            this.id = id;
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    lblNoteDate.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    lblNoteDate.ForeColor = Color.White;
                    lblNoteTitle.ForeColor = Color.White;
                    break;
                case "Dark":
                    lblNoteDate.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    lblNoteDate.ForeColor = Color.White;
                    lblNoteTitle.ForeColor = Color.White;
                    break;
                case "Light":    
                    lblNoteDate.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    lblNoteDate.ForeColor = Color.Black;
                    lblNoteTitle.ForeColor = Color.Black;
                    btnSaveNote.ForeColor = Color.Black;
                    break;
            }
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = RJMessageBox.Show("Xác nhận xóa ghi chú?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            else
                return;
        }

        public void SetTitle(string Title)
        {
            lblNoteTitle.Text = Title;
        }

        public void SetDate()
        {
            lblNoteDate.Text = DateTime.Now.ToString();
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        private void PanelNote_Click(object sender, EventArgs e)
        {
            new FormNoteInfo(theme, lblNoteTitle.Text, content).Show();
        }

        private void BtnSaveNote_Click(object sender, EventArgs e)
        {
            Note note = new Note(lblNoteTitle.Text, content, id);
            if (BLL_QLGC.Instance.AddNewNote(note))
            {
                Alert("Thêm ghi chú mới thành công", Form_Alert.EnmType.Success);
                Dispose();
            }
            else
                Alert("Thêm ghi chú thất bại", Form_Alert.EnmType.Error);
        }
    }
}
