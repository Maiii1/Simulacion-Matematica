using Python.Runtime;
using System.IO;
using RDotNet;

namespace SimESPOL
{
    public partial class PruebaSim : Form
    {
        private REngine ptrR;

        private string ImagePath = @"C:\Users\maitt\Downloads\Maitte.png";

        public PruebaSim()
        {
            InitializeComponent();

            string pythonDllPath = @"C:\Users\maitt\AppData\Local\Programs\Python\Python314\python314.dll";

            Runtime.PythonDLL = pythonDllPath;
            PythonEngine.Initialize();

            REngine.SetEnvironmentVariables(
                rPath: @"C:/Program Files/R/R-4.5.3/bin/x64",
                rHome: @"C:/Program Files/R/R-4.5.3"
            );

            this.ptrR = REngine.GetInstance();

            this.ptrR.Evaluate(
                "Sys.setenv(PATH = paste('C:/Program Files/R/R-4.5.3/bin/x64', Sys.getenv('PATH'), sep=';'))"
            );
        }

        private void btnComputar_Click(object sender, EventArgs e)
        {
            double alpha = double.Parse(txtAlpha.Text);
            double beta = double.Parse(txtBeta.Text);
            int n = int.Parse(txtN.Text);

            double a = 1;
            double b = -2;
            double c = 3;

            FuncionCuadratica obj = new FuncionCuadratica(a, b, c);

            double resultado = obj.IntegralSim(alpha, beta, n);

            txtResultado.Text = resultado.ToString();

            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.insert(0, @"C:\Users\maitt\Downloads");

                dynamic pyModule = Py.Import("SM");

                pyModule.graficar_cuadratica(
                    a, b, c,
                    alpha, beta,
                    ImagePath,
                    pb.Width,
                    pb.Height
                );

                if (pb.Image != null)
                {
                    pb.Image.Dispose();
                    pb.Image = null;
                }

                if (File.Exists(ImagePath))
                {
                    using (var img = new Bitmap(ImagePath))
                    {
                        pb.Image = new Bitmap(img);
                    }

                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Refresh();
                }
            }
        }

        private void btnComputar2_Click(object sender, EventArgs e)
        {
            double alpha = double.Parse(txtAlpha.Text);
            double beta = double.Parse(txtBeta.Text);
            int n = int.Parse(txtN.Text);

            double a = 1;
            double b = -2;
            double c = 3;

            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.insert(0, @"C:\Users\maitt\Downloads");

                dynamic pyModule = Py.Import("SM");

                double ValorIntegral = pyModule.IntegrarSimBBS(
                    a, b, c,
                    n,
                    alpha, beta,
                    1009, 2027, 17
                );

                txtResultado.Text = ValorIntegral.ToString();
            }
        }

        private void btnComputar3_Click(object sender, EventArgs e)
        {
            double alpha = double.Parse(txtAlpha.Text);
            double beta = double.Parse(txtBeta.Text);
            int n = int.Parse(txtN.Text);

            double a = 1;
            double b = -2;
            double c = 3;
            int semilla = 21;

            this.ptrR.Evaluate(@"source('C:/Users/maitt/Downloads/codigo.R')");

            NumericVector ValorIntegral = this.ptrR.Evaluate(
                $"IntegrarSIMXorShift32({a}, {b}, {c}, {n}, {alpha}, {beta}, {semilla})"
            ).AsNumeric();

            txtResultado.Text = ValorIntegral[0].ToString();
        }
    }
}