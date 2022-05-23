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
        public FormMinNote(string theme)
        {
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
                    break;
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            Close();
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

        private void panelNote_Click(object sender, EventArgs e)
        {
            new FormNoteInfo(lblNoteTitle.Text, content).Show();
        }
    }
}
