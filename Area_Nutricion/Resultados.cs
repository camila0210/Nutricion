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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            this.Hide();
            registro.Show();
            Form ingreso = new Ingreso();
        }

        private void btnMigrantes_Click(object sender, EventArgs e)
        {
            Form consulta1 = new Migrantes();
            this.Hide();
            consulta1.Show();
            Form resultados = new Resultados();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Form consulta2 = new Consulta2();
            this.Hide();
            consulta2.Show();
            Form resultados = new Resultados();
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            Form consulta3 = new Consulta3();
            this.Hide();
            consulta3.Show();
            Form resultados = new Resultados();
        }
    }
}
