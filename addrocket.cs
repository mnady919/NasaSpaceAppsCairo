using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launchOmatic.PL
{
    public partial class addrocket : Form
    {
        public addrocket()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            BL.gc w = new BL.gc();

            w.uh(dat.Value, com.Text, payloadratio.Text, luve.Text, eng.Text, dim.Text, fu.Text, you.Text, payloadratio.Text, vie.Text, mis.Text);

            MessageBox.Show("Added");
        }

        private void addrocket_Load(object sender, EventArgs e)
        {
        }
    }
}
