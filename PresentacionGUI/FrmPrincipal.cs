using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroPersona frmRegistroPersona = new FrmRegistroPersona();
            frmRegistroPersona.ShowDialog();
        }
    }
}
