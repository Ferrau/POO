using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CARTUCHO cartucho = new CARTUCHO();
            cartucho.Nivel = 10;

            IMPRESORA imp;
                
            if(radioButton1.Checked)
            {
                imp = new IMPRESORA();
            }
            else
            {
                imp = new IMPRESORA_COLOR();

                IMPRESORA_COLOR imc = (IMPRESORA_COLOR)imp;
                
                imc.Cyan = new CARTUCHO();
                imc.Cyan.Nivel = 10;
                imc.Amarillo = new CARTUCHO();
                imc.Amarillo.Nivel = 10;
                imc.MG = new CARTUCHO();
                imc.MG.Nivel = 10;



            }
                
            
            imp.Negro = cartucho;

            listBox1.Items.Add(imp);


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMPRESORA imp = listBox1.SelectedItem as IMPRESORA;

            label5.Text = imp.Imprimir();

            Mostrar(imp);

        }

        void Mostrar(IMPRESORA imp)
        {
            label1.Text = "Nivel de tinta negra: " + imp.Negro.Nivel.ToString();
            if(imp is IMPRESORA_COLOR)
            {
                label2.Text = "Nivel de tinta cyan: " + ((IMPRESORA_COLOR) imp).Cyan.Nivel.ToString();
                label3.Text = "Nivel de tinta mg: " + ((IMPRESORA_COLOR)imp).MG.Nivel.ToString();
                label4.Text = "Nivel de tinta Amarillo: " + ((IMPRESORA_COLOR)imp).Amarillo.Nivel.ToString();
            }
            else
            {
                label2.Text = "N/A";
                label3.Text ="N/A";
                label4.Text ="N/A";

            }



        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMPRESORA imp = listBox1.SelectedItem as IMPRESORA;
            Mostrar(imp);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
