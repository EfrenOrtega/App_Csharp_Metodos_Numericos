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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int xClick = 0, yClick = 0;


        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
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
