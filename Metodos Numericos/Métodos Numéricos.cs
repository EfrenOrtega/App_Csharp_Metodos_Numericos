using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Metodos_Numericos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PanelSelector.Visible = false;

            /*Change Variables Buttons
            BtnMethod2.Visible = false;
            BtnMethod3.Visible = false;
            BtnMethod4.Visible = false;*/

        }

        public int xClick = 0, yClick = 0;


        //Method to open a form inside of panel
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)            
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(childForm);
                panelContainer.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();            
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(255, 64, 64);

        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(22, 26, 29);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(44, 50, 55);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(22, 26, 29);
        }

        private void BtnMethod1_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod1.Height;
            PanelSelector.Top = BtnMethod1.Top;
            PanelSelector.Left = BtnMethod1.Left;
            BtnMethod1.BackColor = Color.FromArgb(32, 40, 46); ;

            openChildFormInPanel(new Form4());
        }

        private void BtnMethod2_Click(object sender, EventArgs e)
        {
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod2.Height;
            PanelSelector.Top = BtnMethod2.Top;
            BtnMethod2.BackColor = Color.FromArgb(32, 40, 46);

            openChildFormInPanel(new EulerMejorado());
        }

        private void BtnMethod3_Click(object sender, EventArgs e)
        {
            /*PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod3.Height;
            PanelSelector.Top = BtnMethod3.Top;
            BtnMethod3.BackColor = Color.FromArgb(32, 40, 46);

            openChildFormInPanel(new RungeKutta());*/
        }

        private void BtnMethod4_Click(object sender, EventArgs e)
        {
            /*PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod4.Height;
            PanelSelector.Top = BtnMethod4.Top;
            BtnMethod4.BackColor = Color.FromArgb(32, 40, 46);*/
        }


        private void BtnMethod1_Leave(object sender, EventArgs e)
        {
            BtnMethod1.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod2_Leave(object sender, EventArgs e)
        {
            BtnMethod2.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod3_Leave(object sender, EventArgs e)
        {
            //BtnMethod3.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod4_Leave(object sender, EventArgs e)
        {
            //BtnMethod4.BackColor = Color.FromArgb(38, 50, 57);
        }


        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Info F3 = new Info();
            F3.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoxMethod1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form4());
        }

        private void BoxMethod2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EulerMejorado());
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X; yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }
    }
}
