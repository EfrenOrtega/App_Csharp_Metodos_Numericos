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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;


            if (panel2.Width >= 798) { 
                timer1.Stop();

                Info I = new Info();
                Form2 f2 = new Form2();                
                f2.Show();
                I.ShowDialog();
                this.Hide();                
            }
        }
    }
}
