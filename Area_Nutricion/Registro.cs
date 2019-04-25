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
    public partial class Registro : Form
    {
        Validacion v = new Validacion();
        public Registro()
        {
            InitializeComponent();
        }


        private void cbxIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {



            
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            Form resultados = new Resultados();
            this.Hide();
            resultados.Show();
            Form registro = new Registro();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            

            MessageBox.Show("Los datos se han guardado correctamente.");

        }


        private bool ValidarDatos()

        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                erpMensaje.SetError(txtNombre, "Por favor ingrese su nombre");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtNombre, null);
            }

            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                erpMensaje.SetError(txtApellido, "Por favor ingrese su apellido");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtApellido, null);
            }

            if (cbxIdentificacion.SelectedItem == null)
            {
                erpMensaje.SetError(cbxIdentificacion, "Por favor ingrese su tipo de identificación");
                return false;
            }
            else
            {
                erpMensaje.SetError(cbxIdentificacion, null);
            }


            if (string.IsNullOrEmpty(txtNumero.Text.Trim()))
            {
                erpMensaje.SetError(txtNumero, "Por favor ingrese su número de identificación");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtNumero, null);
            }

            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (fechaNacimiento > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha del sistema");
                return false;
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, null);
            }

            if (cbxGenero.SelectedItem == null)
            {
                erpMensaje.SetError(cbxGenero, "Por favor seleccione su género");
                return false;
            }
            else
            {
                erpMensaje.SetError(cbxGenero, null);
            }

            if (cbxEstadoCivil.SelectedItem == null)
            {
                erpMensaje.SetError(cbxEstadoCivil, "Por favor ingrese su estado civil");
                return false;
            }
            else
            {
                erpMensaje.SetError(cbxEstadoCivil, null);
            }

            if (string.IsNullOrEmpty(txtHijos.Text.Trim()))
            {
                erpMensaje.SetError(txtHijos, "Por favor ingrese su número de hijos");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtHijos, null);
            }

            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
            {
                erpMensaje.SetError(txtDireccion, "Por favor ingrese su dirección");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtDireccion, null);
            }

            if (string.IsNullOrEmpty(txtBarrio.Text.Trim()))
            {
                erpMensaje.SetError(txtBarrio, "Por favor ingrese su barrio");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtBarrio, null);
            }

            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                erpMensaje.SetError(txtTelefono, "Por favor ingrese su teléfono");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtTelefono, null);
            }

            if (string.IsNullOrEmpty(txtTelefonoContac.Text.Trim()))
            {
                erpMensaje.SetError(txtTelefonoContac, "Por favor ingrese su teléfono de contacto");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtTelefonoContac, null);
            }

            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                erpMensaje.SetError(txtEmail, "Por favor ingrese su e-mail");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtEmail, null);
            }

            if (string.IsNullOrEmpty(txtOcupacion.Text.Trim()))
            {
                erpMensaje.SetError(txtOcupacion, "Por favor ingrese su ocupación");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtOcupacion, null);
            }

            if (cbxEscolaridad.SelectedItem == null)
            {
                erpMensaje.SetError(cbxEscolaridad, "Por favor ingrese su nivel de escolaridad");
                return false;
            }
            else
            {
                erpMensaje.SetError(cbxEscolaridad, null);
            }

            if (string.IsNullOrEmpty(txtPaisOrigen.Text.Trim()))
            {
                erpMensaje.SetError(txtPaisOrigen, "Por favor ingrese su país de origen");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPaisOrigen, null);
            }

            if (string.IsNullOrEmpty(txtPermanencia.Text.Trim()))
            {
                erpMensaje.SetError(txtPermanencia, "Por favor ingrese su permanencia en el país");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPermanencia, null);
            }

            if (cbxRegimen.SelectedItem == null)
            {
                erpMensaje.SetError(cbxRegimen, "Por favor ingrese su régimen");
                return false;
            }
            else
            {
                erpMensaje.SetError(cbxRegimen, null);
            }

            if (string.IsNullOrEmpty(txtEps.Text.Trim()))
            {
                erpMensaje.SetError(txtEps, "Por favor ingrese su EPS");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtEps, null);
            }

            if (cbxActividad.SelectedItem == null)
            {
                erpMensaje.SetError(cbxActividad, "Por favor ingrese su actividad física");
                return false;
            }
            else
            {
                erpMensaje.SetError(cbxActividad, null);
            }

            if (string.IsNullOrEmpty(txtEstatura.Text.Trim()))
            {
                erpMensaje.SetError(txtEstatura, "Por favor ingrese su estatura");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtEstatura, null);
            }

            if (string.IsNullOrEmpty(txtPeso.Text.Trim()))
            {
                erpMensaje.SetError(txtPeso, "Por favor ingrese su peso");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPeso, null);
            }


            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           

                Application.Exit();

           
        }

        private void lblAdicional_Click(object sender, EventArgs e)
        {

        }

        private void lblActividad_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtNumero.Text, out num))
            {
                erpMensaje.SetError(txtNumero, "Ingrese un número");
            }
            else
            {
                erpMensaje.SetError(txtNumero, "");
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtTelefonoContac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoContac_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtPermanencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
