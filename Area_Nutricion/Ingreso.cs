using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Nutricion
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            if (!ValidarDatosIngreso())
            {
                return;
            }

            Form registro = new Registro();
            this.Hide();
            registro.Show();
            Form ingreso = new Ingreso();

        }

        private bool ValidarDatosIngreso()

        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                erpMensaje.SetError(txtUsuario, "Por favor ingrese su usuario");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtUsuario, null);
            }

            if (string.IsNullOrEmpty(txtContra.Text.Trim()))
            {
                erpMensaje.SetError(txtContra, "Por favor ingrese su contraseña");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtContra, null);
            }

            return true;

        }
    }

}
