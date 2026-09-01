using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimESPOL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarExp_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLambdaExp.Text, out double lambda) || lambda <= 0)
            {
                MessageBox.Show("Ingrese un lambda válido mayor que cero.");
                return;
            }

            if (!double.TryParse(txtCotaExp.Text, out double cota) || cota <= 0)
            {
                MessageBox.Show("Ingrese una cota válida mayor que cero.");
                return;
            }

            if (!int.TryParse(txtMuestraExp.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Ingrese un tamaño de muestra válido.");
                return;
            }

            AcepYRech_exponencial.lambda = lambda;
            AcepYRech_exponencial.cota = cota;

            double[] muestra = AcepYRech_exponencial.GetMuestra(n);

            lstMuestraExp.Items.Clear();

            double suma = 0;

            for (int i = 0; i < muestra.Length; i++)
            {
                lstMuestraExp.Items.Add(muestra[i].ToString("F4"));
                suma += muestra[i];
            }

            double media = suma / muestra.Length;

            lblMediaExp.Text = "Media estimada: " + media.ToString("F4");
        }

    }
}
