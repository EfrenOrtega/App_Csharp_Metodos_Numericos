using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Visible = true;
            this.Visible = false;   
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(255, 64, 64);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(22, 26, 29);
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(44, 50, 55);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(22, 26, 29);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMethod1_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod1.Height;
            PanelSelector.Top = BtnMethod1.Top;
            PanelSelector.Left = BtnMethod1.Left;
            BtnMethod1.BackColor = Color.FromArgb(32, 40, 46); ;
        }

        private void BtnMethod2_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod2.Height;
            PanelSelector.Top = BtnMethod2.Top;
            BtnMethod2.BackColor = Color.FromArgb(32, 40, 46);
        }

        private void BtnMethod3_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod3.Height;
            PanelSelector.Top = BtnMethod3.Top;
            BtnMethod3.BackColor = Color.FromArgb(32, 40, 46);
        }

        private void BtnMethod4_Click(object sender, EventArgs e)
        {
            //To add a line styles to the btn when we push on it.
            PanelSelector.Visible = true;
            PanelSelector.Height = BtnMethod4.Height;
            PanelSelector.Top = BtnMethod4.Top;
            BtnMethod4.BackColor = Color.FromArgb(32, 40, 46);
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
            BtnMethod3.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnMethod4_Leave(object sender, EventArgs e)
        {
            BtnMethod4.BackColor = Color.FromArgb(38, 50, 57);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
