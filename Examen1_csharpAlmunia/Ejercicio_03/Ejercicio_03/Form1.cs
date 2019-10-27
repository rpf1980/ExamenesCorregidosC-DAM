using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        Complejo c = new Complejo();
        Complejo objeto1 = null;
        Complejo objeto2 = null;
        string strReal1 = "";
        string strImag1 = "";
        string strReal2 = "";
        string strImag2 = "";
        public Form1()
        {
            InitializeComponent();
            button3.FlatAppearance.BorderColor = Color.Blue;          
        }

        //Btn SUMA
        private void button3_Click(object sender, EventArgs e)
        {
            strReal1 = idN1ParteReal.Text;
            strImag1 = idN1ParteImaginaria.Text;
            strReal2 = idN2ParteReal.Text;
            strImag2 = idN2ParteImaginaria.Text;

            objeto1 = new Complejo(Convert.ToInt32(strReal1), Convert.ToInt32(strImag1));
            objeto2 = new Complejo(Convert.ToInt32(strReal2), Convert.ToInt32(strImag2));

            Complejo resultado1 = c.Suma(objeto1, objeto2);
            string str = resultado1.Mostrar();
            idTbSuma.Text = str;
        }

        //Btn PRODUCTO
        private void button4_Click(object sender, EventArgs e)
        {
            strReal1 = idN1ParteReal.Text;
            strImag1 = idN1ParteImaginaria.Text;
            strReal2 = idN2ParteReal.Text;
            strImag2 = idN2ParteImaginaria.Text;

            objeto1 = new Complejo(Convert.ToInt32(strReal1), Convert.ToInt32(strImag1));
            objeto2 = new Complejo(Convert.ToInt32(strReal2), Convert.ToInt32(strImag2));

            Complejo resultado2 = c.Multiplicar(objeto1, objeto2);
            string str = resultado2.Mostrar();
            idTbProducto.Text = str;

        }

        //Mostrar complejo N1
        private void button1_Click(object sender, EventArgs e)
        {
            strReal1 = idN1ParteReal.Text;
            strImag1 = idN1ParteImaginaria.Text;

            idN1MuestraComplejo.Text = $"({strReal1} + {strImag1}i)";
        }

        //Mostrar complejo N2
        private void button2_Click(object sender, EventArgs e)
        {
            strReal2 = idN2ParteReal.Text;
            strImag2 = idN2ParteImaginaria.Text;

            idN2MuestraComplejo.Text = $"({strReal2} + {strImag2}i)";
        }
    }
}
