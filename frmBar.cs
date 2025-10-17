﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoSP4
{
    public partial class frmBar : Form
    {
        public frmBar()
        {
            InitializeComponent();
        }

        float[,] matVentas = new float[5,4];

        private void frmBar_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");


            dgvVentas.Rows[0].Cells[0].Style.BackColor = Color.LightGray;
            dgvVentas.Rows[1].Cells[0].Style.BackColor = Color.LightGray;
            dgvVentas.Rows[2].Cells[0].Style.BackColor = Color.LightGray;
            dgvVentas.Rows[3].Cells[0].Style.BackColor = Color.LightGray;
            dgvVentas.Rows[4].Cells[0].Style.BackColor = Color.LightGray;

            dgvVentas.Rows[0].Cells[0].Selected = false;
            dgvVentas.Rows[0].Cells[1].Selected = true;

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            for (int indiceFilas = 0; indiceFilas < dgvVentas.Rows.Count; indiceFilas++)
            {
                for (int indiceColumnas = 1; indiceColumnas < dgvVentas.Columns.Count; indiceColumnas++)
                {

                    if (dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value != null)
                    {
                        float contenidoCelda =
                        float.Parse(dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value.ToString());

                        if (float.IsRealNumber(contenidoCelda))
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "si";
                        }
                        else
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "no";
                        }
                    }
                }
            }        
        }
    }
}
