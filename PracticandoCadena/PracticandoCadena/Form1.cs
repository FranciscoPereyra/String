using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticandoCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string cadena = tbCadena.Text;

            //Para ver la longitud de la cadena
            tbLongitud.Text = Convert.ToString(cadena.Length);

            //Para ver el último caracter
            tbUltimo.Text = cadena.Substring(cadena.Length - 1, 1);

            //Para ver el primer caractetr
            tbPrimer.Text = cadena.Substring(0, 1);

            //Para ver la subcadena entre el 2 y 6 caracter
            tbEntreDosySeis.Text = cadena.Substring(1, 8);

            //Para ver la posición de la letra "A"
            tbLetraA.Text = Convert.ToString(cadena.IndexOf("a-A", 0)+1);

            //Para pasar a mayúsculas a toda la cadena
            tbMayusculas.Text = cadena.ToUpper();

            //Para pasar a minúscula a toda la cadena
            tbMinuscula.Text = cadena.ToLower();

            //Para borrar los espacios en blanco de la cadena
            tbBorrarEspacios.Text = cadena.Replace("*", "-.-");

            //Para separar las cadena
            string[] palabras = cadena.Split('*');

            foreach (string palabra in palabras)
            {
                //   Console.WriteLine(palabra);
                listBox1.Items.Add(palabra);
            }




        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
