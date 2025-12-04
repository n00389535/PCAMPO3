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
        string[] nombres = new string[10];
        double[] monto = new double[10];
        int[] periodo = new int[10];
        double[] cuota = new double[10];

        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            lstCliente.Items.Clear();
            lstMonto.Items.Clear();
            lstPeriodo.Items.Clear();
            lstCuota.Items.Clear();

            for (int i = 0; i < indice; i++)
            {
                lstCliente.Items.Add(nombres[i]);
                lstMonto.Items.Add(monto[i].ToString("F2"));
                lstPeriodo.Items.Add(periodo[i].ToString());
                lstCuota.Items.Add(cuota[i].ToString("F2"));
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            double tasa;

            nombres[indice] = txtNombre.Text;
            monto[indice] = Convert.ToDouble(txtMonto.Text);
            periodo[indice] = Convert.ToInt32(cboPeriodo.Text);
            tasa = Convert.ToDouble(txtTasa.Text) / 100;
            cuota[indice] = Math.Pow((1 + tasa), periodo[indice]) - 1;
            indice++;

            if (indice >= 10)
            {
                MessageBox.Show("Arreglo lleno");
            }
        }

        private void btnBurbuja_Click_1(object sender, EventArgs e)
        {
            double auxMonto, auxCuota;
            string auxNombre;
            int auxPeriodo;
            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = i + 1; j < indice; j++)
                {
                    if (monto[i] > monto[j])
                    {
                        //intercambio de montos
                        auxMonto = monto[i];
                        monto[i] = monto[j];
                        monto[j] = auxMonto;


                        //intercambio de nombres
                        auxNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNombre;

                        //intercambio de periodos
                        auxPeriodo = periodo[i];
                        periodo[i] = periodo[j];
                        periodo[j] = auxPeriodo;

                        //intercambio de cuotas
                        auxCuota = cuota[i];
                        cuota[i] = cuota[j];
                        cuota[j] = auxCuota;
                    }
                }
            }
        }
    }
}
