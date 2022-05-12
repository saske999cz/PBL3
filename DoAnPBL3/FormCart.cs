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
    public partial class FormCart : Form
    {
        private int Count = 0;
        static int z = 0;
        FormNhapMua[] currentChildForm = new FormNhapMua[100];
        public FormCart()
        {
            InitializeComponent();
        }

        
        private void OpenChildForm(FormNhapMua childForm)
        {



            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Top;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnOK_Click(object sender, EventArgs e)
        { 
            int Num = 0;
            if (tbNumber.Texts == "")
                RJMessageBox.Show("Vui lòng nhập số lượng loại sách muốn mua", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                Num = Convert.ToInt32(tbNumber.Texts);
                Count += Num;
                if (Count <=100)
                {
                    for (int j = 0; j < Num; j++)
                    {
                        currentChildForm[z] = new FormNhapMua(z + 1);
                        OpenChildForm(currentChildForm[z]);

                        z++;

                    }

                }
                else if (Count > 100)
                {
                    RJMessageBox.Show("Số lượng loại sách vượt quá giới hạn cho phép", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Count -= Num;
                }
            }
                tbNumber.Texts = "";
                panelDesktop.Focus();
            


        }

        private void tbNumber__TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tbNumber.Texts);
            foreach(byte b in asciiBytes)
            {
                if (b > 57 || b < 47)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {

                RJMessageBox.Show("Chỉ được nhập số", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumber.Texts = "";

            }

           
        }

        private void rjbtnBuy_Click(object sender, EventArgs e)
        { bool check = true;
            int[] error = new int[100];
            int indexError = 0;
            
            if (panelDesktop.Controls.Count != 0)
            {
                foreach (FormNhapMua b in panelDesktop.Controls)
                {
                    if (b.GetSLText() == "0" || b.GetSLText() == "")
                    {
                        check = false;
                        error[indexError] = panelDesktop.Controls.Count - panelDesktop.Controls.GetChildIndex(b) ;
                        indexError++;
                       
                    }
                }
                if (check == true)
                {
                    
                    this.Alert("Mua sách thành công", Form_Alert.enmType.Success);
                    z = 0;
                    this.Close();
                }
                else
                {   int o = 0;
                    int[] v = new int[indexError];
                    for (int i = indexError - 1; i >= 0; i--)
                    {
                        v[i] = error[o];
                        o++;
                    }
                        
                    
                    RJMessageBox.Show("Vui lòng nhập các thông tin cần thiết trước khi nhấn mua", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RJMessageBox.Show("Xuất hiện sai sót tại dòng: " + string.Join(", ", v), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                RJMessageBox.Show("Chưa có sách nào trong giỏ hàng của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            z = 0;
            this.Close();
        }

       

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                
            }
        }

        

        private void panelDesktop_ControlAdded(object sender, ControlEventArgs e)
        {
            
            Tinh();
            
            


        }

        private void panelDesktop_ControlRemoved(object sender, ControlEventArgs e)
        {
            z = panelDesktop.Controls.Count;
            Count--;
            foreach (FormNhapMua b in panelDesktop.Controls)
            {
                
                
                    b.SetIndex(panelDesktop.Controls.Count - panelDesktop.Controls.GetChildIndex(b));
                    b.SetIndexText();
                

            }




            Tinh();
            
            
        }

        

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

            Tinh();

        }

        



        private void FormCart_Load(object sender, EventArgs e)
        {

            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tinh();
        }

        private void Tinh()
        {
            int Quantity = 0;
            long total = 0;
            foreach ( FormNhapMua b in panelDesktop.Controls)
            {
                
                    if (b.GetSLText() == "")
                        Quantity += 0;
                    else
                        Quantity += b.GetSL();
                    if (b.GetCPText() == "")
                        total += 0;
                    else
                        total += b.GetCP();
                
            }

            tbTotal.Text = total.ToString();
            tbNumDiverse.Text = panelDesktop.Controls.Count.ToString();
            tbQuantity.Text = Quantity.ToString();

        }

        
    }
}