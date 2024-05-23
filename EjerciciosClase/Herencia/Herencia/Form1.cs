using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impresora imp = null;
            if (radioButton1.Checked)
            {    
                imp = new Impresora();           
          
            }
            else
            {
                imp = new ImpresoraColor();               

            }
            listBox1.Items.Add(imp);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impresora imp = (Impresora)listBox1.SelectedItem;
            string resultado = imp.Imprimir(textBox1.Text);

            listBox2.Items.Insert(0,resultado);
            MostrarNivel();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarNivel();
        }

        void MostrarNivel()
        {
            Impresora imp = (Impresora)listBox1.SelectedItem;
            label1.Text = "Nivel Negro: " + imp.Negro.Nivel.ToString();

            if(imp is ImpresoraColor)
            {
                ImpresoraColor impc = (ImpresoraColor)imp;
                label2.Text ="Nivel azul " + impc.Cyan.Nivel.ToString();
                label3.Text ="Nivel amarillo " + impc.Amarillo.Nivel.ToString();
                label4.Text = "Nivel magenta " + impc.Magenta.Nivel.ToString();
            }
            else
            {
                label2.Text ="No disponible";
                label3.Text ="No disponible";
                label4.Text = "No disponible";
            }



        }

    }
}
