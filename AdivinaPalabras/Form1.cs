using System;
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

        List<ModeloPalabra> listaDePalabras = new List<ModeloPalabra>(); 
        

        string[] palabras = { "como", "bro", "amr", "bebe", "buenos" };

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

            foreach (var item in listaDePalabras)
            {
                
                for (int i = 0; i < item.palabra.Length; i++)
                {
                    if (i < 2)
                    {
                        seccion += item.palabra[i];
                    }
                    else if (i >= 2)
                    {
                        break;
                    }
                }
                if (seccion == textBox6.Text)
                {
                    palabra_encontrada = item.palabra;
                    break;
                }
            }

            return palabra_encontrada;
        }
        private void actualiza() 
        {
            for (int i = 0; i <= listaDePalabras.Count(); i++)
            {
                textBox1.Text = palabras[0];
                textBox2.Text = palabras[1];
                textBox3.Text = palabras[2];
                textBox4.Text = palabras[3];
                textBox5.Text = palabras[4];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaDePalabras.Add(new ModeloPalabra("como", 0.9));
            listaDePalabras.Add(new ModeloPalabra("bro", 0.7));
            listaDePalabras.Add(new ModeloPalabra("amr", 0.5));
            listaDePalabras.Add(new ModeloPalabra("babe", 0.2));
            listaDePalabras.Add(new ModeloPalabra("buenos", 0.1));
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
