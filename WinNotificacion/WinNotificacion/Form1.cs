using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNotificacion
{
    public partial class fmrMensaje : Form
    {
        public fmrMensaje()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Telefono = txtTelefono.Text;

            frmNotificacion  frmMes = new frmNotificacion(persona);
            frmMes.ShowDialog();
 
        }
    }
}
