﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Espacos : MetroFramework.Forms.MetroForm
    {
        public Espacos()
        {
            InitializeComponent();
        }

        private void Salas_Load(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Defaults();
        }

        private void Defaults()
        {
            tbDesignacao.Text = "";
            nudMax.Value = 1;
            tbInicio.Text = "";
            tbFim.Text = "";
            tbNotas.Text = "";
        }
    }
}
