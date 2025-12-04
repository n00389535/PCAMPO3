using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAMPO3
{
    public partial class Form1 : Form
    {
        string nombre, apellidos, nombreCompleto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            nombre = txtNombre.Text;
            apellidos = txtApellido.Text;
            nombreCompleto = nombre + " " + apellidos;

            lstResultado.Items.Add("Concatenación: " + nombreCompleto);
        }

        private void btnLongitud_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add("Longitud del nombre: " + nombre.Length);

        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add("Nombre sin espacios: " + nombre.Trim() + " " + apellidos.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicion = Convert.ToInt32(txtPosicion.Text);
            int numCaracteres = Convert.ToInt32(txtNumCaracteres.Text);

            if (nombreCompleto.Length >= 3)
            {
                lstResultado.Items.Add("Primeros " + numCaracteres + " desde laposición " + posicion + " es: " + nombreCompleto.Substring(posicion - 1, numCaracteres));
                return;
            }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            //reemplazar a po @
            lstResultado.Items.Add("Reemplazar a por @: " + nombreCompleto.Replace('a', '@'));
        }



        private void btnIndice_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add("Indice de la 'z': " + (nombreCompleto.IndexOf('z') + 1));

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string[] palabras = nombreCompleto.Split(' ');

            foreach (string palabra in palabras)
                lstResultado.Items.Add(palabra);
        }

        private void btnMayusculas_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add("Nombre en mayusculas: " + nombre.ToUpper() + " " + apellidos.ToUpper());

        }

        private void btnMinúsculas_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add("Nombre en minusculas: " + nombre.ToLower() + " " + apellidos.ToLower());

        }
    }
}
