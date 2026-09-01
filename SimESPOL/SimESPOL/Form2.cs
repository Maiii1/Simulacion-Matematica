using SimESPOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            double media = double.Parse(txtmedia.Text);
            double varianza = double.Parse(txtvar.Text);
            int n = int.Parse(txtmuestra.Text);
            double cota = 3.5;

            double[] Muestra;
            Acep_Rech obj = new Acep_Rech(media, varianza, n, cota);
            Muestra = obj.GenerarMuestra();

            ListaMuestra.Items.Clear();
            double Suma = 0;
            for (int i = 0; i < n; i++)
            {
                Suma += Muestra[i];
                ListaMuestra.Items.Add(Math.Round(Muestra[i], 2));
            }
            double MediaEstimacion = Suma / (double)n;
            MessageBox.Show("Media estimada: " + MediaEstimacion.ToString(), "Simulacion Matematica");
        }

        private void btnGenerarDiscreta_Click(object sender, EventArgs e)
        {
            int[] Soporte = { 320, 340, 350, 380 };
            double[] Prob = { 0.2, 0.4, 0.3, 0.1 };
            AceptacionRechazoDiscreta obj;
            obj = new AceptacionRechazoDiscreta(Soporte, Prob);
            int n = int.Parse(txtmuestra.Text);
            int[] Muestra = obj.GetMuestra(n);
            lstMuestraDiscreta.Items.Clear();
            int Suma = 0;
            for (int i = 0; i < n; i++)
            {
                lstMuestraDiscreta.Items.Add(Muestra[i]);
                Suma += Muestra[i];
            }
            double MediaDiscreta = (double)Suma / (double)n;
            MessageBox.Show("Media discrta estimada: " + MediaDiscreta.ToString(), "Simulacion Matematica");
        }

        private void btnGenerarPoisson_Click(object sender, EventArgs e)
        {
            double lambda = double.Parse(txtLambda.Text);
            int n = int.Parse(txtmuestra.Text);
            double p_min = 0.0000001;

            Poisson.lambda = lambda;
            int Suma = 0;
            int[] Muestra = Poisson.GetMuestra(n, p_min);
            lstMuestraPoisson.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                lstMuestraPoisson.Items.Add(Muestra[i]);
                Suma += Muestra[i];
            }
            double MediaPoisson = (double)Suma / (double)(n);
            MessageBox.Show("Media Poisson estimada: " + MediaPoisson.ToString(), "Simulacion Matematica");

            System.Numerics.BigInteger x = Poisson.Fact(30);
            MessageBox.Show(x.ToString(), "Simulacion Matematica");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}