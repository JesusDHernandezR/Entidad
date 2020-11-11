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
namespace PresentacionGUI
{
    public partial class FrmConsultar : Form
    {
        ContratoService contratacionService;
        public FrmConsultar()
        {
            InitializeComponent();
            contratacionService = new ContratoService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDatos.DataSource = contratacionService.Consultar();
                txtNumeroDeContratos.Text = contratacionService.Consultar().Count.ToString();
                txtTotalValores.Text = contratacionService.Consultar().Sum(contrato => contrato.ValorDeContrato).ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show("ERROR "+f);
            }                                    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumeroDeContratos.Clear();
            txtTotalValores.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
