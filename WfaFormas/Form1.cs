﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaFormas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    ExibirBase(true);
                    ExibirAltura(false);
                    ExibirRaio(false);
                    cmbTriangulo.Visible = false;
                    break;
                case "Triângulo":
                    ExibirRaio(false);
                    ExibirBase(true);
                    cmbTriangulo.Visible = true;
                    cmbTriangulo_TextUpdate(null, null);
                    break;
                default:
                    break;
            }
        }

        private void cmbTriangulo_TextUpdate(object sender, EventArgs e)
        {
            txtBase.Enabled = true;
            txtAltura.Enabled = true;
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    ExibirAltura(false);
                    break;
                case "Isósceles":
                    ExibirAltura(true);
                    break;
                case "Reto":
                    ExibirAltura(true);
                    break;
                default:
                    txtBase.Enabled = false;
                    txtAltura.Enabled = false;
                    break;
            }
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }
        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }
        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado()
                {
                    Lado = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(quadrado);
            }
            else if (cmbForma.Text.Equals("Triângulo"))
            {
                if (cmbTriangulo.Text.Equals("Equilátero"))
                {
                    FormaGeometrica triangulo = new TE()
                    {
                        Lado = Convert.ToDouble(txtBase.Text)
                    };
                    cmbObjetos.Items.Add(triangulo);
                }
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();
        }

        
    }
}
