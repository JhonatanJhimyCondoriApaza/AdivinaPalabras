﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List<ModeloPalabra> listaDePalabras = new List<ModeloPalabra>(); 
        // string[] palabras = { "como", "bro", "amr", "bebe", "buenos" };

        ModeloPalabra[] formales = {
            new ModeloPalabra("como", 0.9),
            new ModeloPalabra("bro", 0.7),
            new ModeloPalabra("amr", 0.5),
            new ModeloPalabra("babe", 0.2),
            new ModeloPalabra("buenos", 0.1)
        };
        ModeloPalabra[] informales = {
            new ModeloPalabra("che", 0.9),
            new ModeloPalabra("prro", 0.7),
            new ModeloPalabra("estimado", 0.5),
            new ModeloPalabra("hermano", 0.2),
            new ModeloPalabra("loco", 0.1)
        };
        ModeloPalabra[] casual = {
            new ModeloPalabra("brow", 0.9),
            new ModeloPalabra("inge", 0.5),
            new ModeloPalabra("chaval", 0.1),
        };

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == " "){

                string valor = adivinar();
                string anterior = textBox6.Text;
                if (valor!="" || valor!=" ")
                {
                    textBox6.Text = anterior + " " + valor;
                }

            }
        }
        private string adivinar() 
        {

            string seccion = "";
            string palabra_encontrada = "";

            foreach (var item in formales)
            {
                
                for (int i = 0; i < item.palabra.Length; i++)
                {
                    if (i > 1)
                    {
                        seccion += item.palabra[i];
                        if (seccion == textBox6.Text)
                        {
                            palabra_encontrada = item.palabra;
                            break;
                        }
                        if (seccion == )
                        {

                        }
                    }
                }
                
            }

            return palabra_encontrada;
        }
        private void actualiza() 
        {
            for (int i = 0; i <= listaDePalabras.Count(); i++)
            {
                textBox1.Text = arreglo[0].palabra;
                textBox2.Text = arreglo[1].palabra;
                textBox3.Text = arreglo[2].palabra;
                textBox4.Text = arreglo[3].palabra;
                textBox5.Text = arreglo[4].palabra;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualiza();
        }


















































































































        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
