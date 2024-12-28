using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNT101
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            rsa.ShowDialog();
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            Playfair playfair = new Playfair();
            playfair.ShowDialog();
        }
    }
}
