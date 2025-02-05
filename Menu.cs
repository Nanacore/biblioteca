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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btUtilizadores_Click(btUtilizadores,e);
            Focus();
            BringToFront();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
        }

        private void btBiblioNet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process start = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://biblioteca.cm-tvedras.pt/Biblionet/";
            start.StartInfo = startInfo;
            start.Start();
        }
        private void PanelShow(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void btUtilizadores_Click(object sender, EventArgs e)
        {
            Utilizadores form = new Utilizadores();
            PanelShow(form);
        }

        private void btEquipamentos_Click(object sender, EventArgs e)
        {
            Equipamentos form = new Equipamentos();
            PanelShow(form);
        }

        private void btSalas_Click(object sender, EventArgs e)
        {
            Espacos form = new Espacos();
            PanelShow(form);
        }

        private void btEmprestimos_Click(object sender, EventArgs e)
        {
            Agenda form = new Agenda();
            PanelShow(form);
        }

        private void btNotas_Click(object sender, EventArgs e)
        {
            Notas form = new Notas();
            PanelShow(form);
        }

        private void biblionet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process start = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://biblioteca.cm-tvedras.pt/Biblionet/";
            start.StartInfo = startInfo;
            start.Start();
        }
    }
}
