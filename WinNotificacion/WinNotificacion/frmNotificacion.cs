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
    public partial class frmNotificacion : Form
    {
        public frmNotificacion(Persona pPer)
        {
            InitializeComponent();

            lbNombre.Text = pPer.Nombre;
            lbDireccion.Text = pPer.Direccion;
            lbTelefono.Text = pPer.Telefono;
        }

        private void frmNotificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
