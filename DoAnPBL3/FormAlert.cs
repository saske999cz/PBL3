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
    public partial class Form_Alert : Form
    {
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private enmAction action;
        private int x, y;

        public Form_Alert()
        {
            InitializeComponent();
        }

        public void showAlert(string msg, enmType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;

                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            switch (type)
            {
                case enmType.Success:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"NotificationIcons\success.png"));
                    BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"NotificationIcons\error.png"));
                    BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"NotificationIcons\info.png"));
                    BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"NotificationIcons\warning.png"));
                    BackColor = Color.DarkOrange;
                    break;
            }
            lblMsg.Text = msg;
            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
    }
}
