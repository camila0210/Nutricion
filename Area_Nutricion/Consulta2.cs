﻿using System;
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
    public partial class Consulta2 : Form
    {
        public Consulta2()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form resultados = new Resultados();
            this.Hide();
            resultados.Show();
            Form consulta2 = new Consulta2();
        }
    }
}
