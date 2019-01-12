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

namespace launchOmatic.PL
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            BL.BLL f = new BL.BLL();
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            byte[] pic = ms.ToArray();
            f.addnewaccount(tc.Text, tp.Text, tu.Text, coun.Text, mail.Text, pic);
            MessageBox.Show("Added one Account", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog smsm = new OpenFileDialog();
            smsm.Filter = "Images | *.PNG; *.JPG; *.gif";
            if (smsm.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(smsm.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
