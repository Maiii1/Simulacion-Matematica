using System;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Acep_Rech
    {
        private double _media;
        private double _varianza;
        private int _n;
        private double _cota;
        private Random AGNA = new Random();

        public Acep_Rech(double media, double varianza, int n, double cota)
        {
            this._media = media;
            this._varianza = varianza;
            this._n = n;
            this._cota = cota;
        }

        public double[] GenerarMuestra()
        {
            double[] Muestra = new double[this._n];
            int Aceptaciones = 0;
            while (true)
            {
                double[] Punto = GenerarPunto();
                if (Punto[1] <= DensidadEstandar(Punto[0]))
                {
                    Muestra[Aceptaciones] = Math.Sqrt(this._varianza) * Punto[0] + this._media;
                    Aceptaciones++;
                }
                if (Aceptaciones == this._n) break;
            }
            return Muestra;
        }
        public double DensidadEstandar(double z)
        {
            double f;
            f = (1.0 / Math.Sqrt(2 * Math.PI)) * Math.Exp(-0.5 * z * z);
            return f;
        }

        public double[] GenerarPunto()
        {
            // Random AGNA = new Random();
            double lambda1 = AGNA.NextDouble();
            double lambda2 = AGNA.NextDouble();
            double x = this._cota * (1 - 2 * lambda1);
            double y = lambda2 / Math.Sqrt(2 * Math.PI);
            double[] Punto = new double[2];
            Punto[0] = x; Punto[1] = y;
            return Punto;
        }
    }
}