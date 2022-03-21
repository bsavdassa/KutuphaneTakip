using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{
    public partial class AnaForm : Form
    {
        AccessDB accdb;
        public AnaForm(AccessDB accdb)
        {
            InitializeComponent();
            this.accdb = accdb;
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new UyeEkleme(accdb).ShowDialog();
        }
    }
}
