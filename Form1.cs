using catanafinals.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catanafinals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        private void openChildForm(Form childform)
        {
            if (activeform != null)
                activeform.Close();

            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //for dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            using (catanaswordEntities _con = new catanaswordEntities())
            {
                openChildForm(new Clients(_con.CLINETINFOes.ToList()));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (catanaswordEntities _con = new catanaswordEntities())
            {
                openChildForm(new Clients(_con.CLINETINFOes.ToList()));
            }
        }
    }
}
