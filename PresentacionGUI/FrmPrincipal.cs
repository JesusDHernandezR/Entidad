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

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database.TablaDatos' Puede moverla o quitarla según sea necesario.
            this.tablaDatosTableAdapter.Fill(this.database.TablaDatos);

        }
    }
}
