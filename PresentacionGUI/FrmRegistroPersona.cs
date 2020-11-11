using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace PresentacionGUI
{
    public partial class FrmRegistroPersona : Form
    {
        PersonaService personaService;
        public FrmRegistroPersona()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = Guardar();
            MessageBox.Show(mensaje);
        }

        public string Guardar()
        {
            Persona persona = MapearTexto();
            string mensaje = personaService.Guardar(persona);
            return mensaje;            
        }

        private Persona MapearTexto()
        {
            var persona = new Persona();
            persona.Id = txtIdentificacion.Text;
            persona.Nombre = txtNombre.Text;
            persona.FechaNacimiento = DateTime.Parse(dateTimePickerNacimiento.Text);
            persona.Direccion = txtDireccion.Text;
            persona.TipoDeContrato = comboBoxTipoContrato.Text;
            persona.ValorDeContrato = decimal.Parse(txtValorContrato.Text);
            persona.CalcularPago();
            //TxtPulsacion.Text = persona.Pulsacion.ToString();
            return persona;
        }
        private void LimpiarTexto()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            dateTimePickerNacimiento.Focus();
            txtDireccion.Clear();
            txtValorContrato.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }
    }
}
