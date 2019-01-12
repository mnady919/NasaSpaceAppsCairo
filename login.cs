using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launchOmatic
{
    public partial class Form1 : Form
    {          
        BL.BLL log = new BL.BLL();
        PL.main z = new PL.main();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tp.Focus();
            }
        }

        private void tp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.Focus();    
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            DataTable dt = log.Login(tu.Text, tp.Text);
            if (dt.Rows.Count > 0)
            {
                z.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            Program.un = tu.Text;
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            PL.reg r = new PL.reg();
            r.ShowDialog();
        }

        private void tu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngu_Click(object sender, EventArgs e)
        {
            PL.guset y = new PL.guset();
            y.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
