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
        double[,] notas = new double[11, 4];

        public Form1()
        {
            InitializeComponent();
        }


        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();

            dgvDatos.Rows.Clear();

            for (int k = 0; k < 11; k++)
            {
                dgvDatos.Rows.Add();
                if(k == 10)
                {
                    dgvDatos.Rows[k].HeaderCell.Value = ("Prom. Curso");
                }
                else
                {
                    dgvDatos.Rows[k].HeaderCell.Value = ("Estudiante " + (k + 1));
                }
            }
            dgvDatos.RowHeadersWidth = 150;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    notas[i, j] = rdn.Next(0, 20);
                    dgvDatos.Rows[i].Cells[j].Value = notas[i, j];
                }
            }
        }

        private void btnPromedioCurso_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; j++)
            {
                double suma = 0;
                for (int i = 0; i < 10; i++)
                {
                    suma += notas[i, j];
                }
                double promedio = (double)suma / 10;
                notas[10, j] = promedio;
                dgvDatos.Rows[10].Cells[j].Value = notas[10, j];
            }
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                }
                double promedio = Math.Round(suma / 3, 2);
                notas[i, 3] = promedio;
                dgvDatos.Rows[i].Cells[3].Value = notas[i, 3];
            }
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                double mejor = 0;
                for (int j = 0; j < 3; j++)
                {
                    if(notas[i, j] > mejor)
                    {
                        mejor = notas[i, j];
                    }
                }
                dgvDatos.Rows[i].Cells[3].Value = mejor;
            }
        }










        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
