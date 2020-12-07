using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Data.SqlClient;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        SqlConnection Connection;
        
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

        }

        private void BtnConectarABd_Click(object sender, EventArgs e)
        {
            ConectarDB();
        }

        private static void ConectarDB()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Estado de conexion: " + connection.State, "Informe", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
