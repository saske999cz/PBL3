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
    public partial class FormMenuNote : Form
    {
        FormNote note = new FormNote();
        FormMinNote[] minNote = new FormMinNote[100];
        static int count = 0;
        static int index = 0;
        private string theme;
        string[] content = new string[100];
        public FormMenuNote(string theme)
        {
            this.theme = theme;
            InitializeComponent();
            Notes.BringToFront();
            switch (theme)
            {
                case "Admin":
                    Notes.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    Notes.BackColor = Color.FromArgb(34, 33, 74);
                    break;

                case "Dark":
                    Notes.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    Notes.BackColor = Color.FromArgb(32, 32, 32);
                    break;

                case "Light":
                    Notes.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    Notes.BackColor = Color.FromArgb(220, 220, 220);
                    break;
            }

        }

        private void OpenChildForm(FormMinNote childForm)
        {



            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Top;
            Notes.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            note = new FormNote();
            note.Show();
            
            
        }

        private void FormMenuNote_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Notes.Refresh();
            
        }

        private void FormMenuNote_Load(object sender, EventArgs e)
        {
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Notes_Paint(object sender, PaintEventArgs e)
        {
            if (note.Text == "Changed")
            {
                content[index] = note.GetContent();
                minNote[index] = new FormMinNote(theme);
                OpenChildForm(minNote[index]);
                minNote[index].SetTitle(note.GetTitle());
                minNote[index].SetDate();
                minNote[index].SetContent(content[index]);
                count++;
                index++;
                note.Text = "NotChanged";
                //Notes.Show();
               
            }
        }
    }
}
