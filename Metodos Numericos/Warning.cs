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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, -3, Width, Height, 25, 25));

        }

        //To add border radius to the application
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomReact,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
