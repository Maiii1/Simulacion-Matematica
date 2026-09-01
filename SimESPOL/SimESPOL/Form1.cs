using Python.Runtime;
using System.IO;
using RDotNet;

namespace SimESPOL
{
    public partial class Form1 : Form
    {
        private string ImagePath = @"C:\Users\maitt\Downloads\Maitte.png";
        private REngine ptrR;

        public Form1()
        {
            InitializeComponent();

            string pythonDllPath = @"C:\Users\maitt\AppData\Local\Programs\Python\Python314\python314.dll";
            Runtime.PythonDLL = pythonDllPath;
            PythonEngine.Initialize();

            REngine.SetEnvironmentVariables(
                rPath: @"C:\Program Files\R\R-4.5.2\bin\x64",
                rHome: @"C:\Program Files\R\R-4.5.2"
            );

            ptrR = REngine.GetInstance();

            ptrR.Evaluate(
                "Sys.setenv(PATH = paste('C:/Program Files/R/R-4.5.2/bin/x64', Sys.getenv('PATH'), sep=';'))"
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

            FuncionCuadratica funcion = new FuncionCuadratica(a, b, c);

            double resultado = funcion.IntegralSim(alpha, beta, n);

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
            }

            CargarImagen();
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

            ptrR.Evaluate(
                @"source('C:/Users/maitt/Downloads/codigo.R')"
            );

            NumericVector ValorIntegral = ptrR.Evaluate(
                $"IntegrarSIMxorShift32({a}, {b}, {c}, {n}, {alpha}, {beta}, {semilla})"
            ).AsNumeric();

            txtResultado.Text = ValorIntegral[0].ToString();

            string rutaImagenR = ImagePath.Replace("\\", "/");

            ptrR.Evaluate(
                $"graficar_cuadratica({a}, {b}, {c}, {alpha}, {beta}, '{rutaImagenR}', {pb.Width}, {pb.Height})"
            );

            CargarImagen();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            EstimarSIM obj = new EstimarSIM();

            double estimacion = obj.EstimarPI(n);

            txtEstimacion.Text = estimacion.ToString();
        }

        private void CargarImagen()
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPI_Click_1(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            EstimarSIM obj = new EstimarSIM();

            double estimacion = obj.EstimarPI(n);

            txtEstimacion.Text = estimacion.ToString();
        }

        private void btnJuegoDados_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            double suma = 0;

            EstimarSIM obj = new EstimarSIM();

            for (int i = 0; i < n; i++)
            {
                int GP;

                int[,] Jugadas = obj.JugarDados(30, out GP);

                suma += GP;
            }

            double mediaGP = suma / (double)n;

            txtEstimacion.Text = mediaGP.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            EstimarSIM obj = new EstimarSIM();

            double estimacion = obj.EstimarE(n);

            txtEstimacion.Text = estimacion.ToString();
        }

        private void btnProbCondicional_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            double ProbCondicional;

            double ProbBeca = EstimarSIM.EstimarProbCondicional(n, out ProbCondicional);

            label5.Text = "Prob. de beca";
            txtResultado.Text = ProbBeca.ToString();

            label7.Text = "Prob. condicional";
            txtEstimacion.Text = ProbCondicional.ToString();

        }
    }
}