using SM;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimESPOL
{
    public class FuncionCuadratica
    {
        private double _a;
        private double _b;
        private double _c;

        public FuncionCuadratica(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public double Evaluar(double abscisa)
        {
            double ordenada;

            ordenada = this._a +
                       this._b * abscisa +
                       this._c * Math.Pow(abscisa, 2);

            return ordenada;
        }

        public double IntegralSim(double alpha, double beta, int n)
        {
            double valorIntegral;

            ACL.Inicializar(5, 7);

            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                double lambda = ACL.Siguiente();

                double dom = lambda * alpha +
                             (1 - lambda) * beta;

                double img = this.Evaluar(dom);

                suma += img;
            }

            valorIntegral = ((beta - alpha) * suma) / n;

            return valorIntegral;
        }
    }
}