using System;

namespace SimESPOL
{
    internal class AcepYRech_exponencial
    {
        public static double lambda;
        public static double cota;

        private static Random AGNA = new Random();

        // Densidad de la distribución exponencial
        public static double Densidad(double x)
        {
            if (x < 0)
            {
                return 0;
            }

            return lambda * Math.Exp(-lambda * x);
        }

        // Generar una muestra mediante aceptación y rechazo
        public static double[] GetMuestra(int n)
        {
            if (lambda <= 0)
            {
                throw new ArgumentException(
                    "Lambda debe ser mayor que cero."
                );
            }

            if (cota <= 0)
            {
                throw new ArgumentException(
                    "La cota debe ser mayor que cero."
                );
            }

            if (n <= 0)
            {
                throw new ArgumentException(
                    "El tamaño de la muestra debe ser mayor que cero."
                );
            }

            double[] Muestra = new double[n];

            int Aceptaciones = 0;

            // La altura máxima de la exponencial es f(0) = lambda
            double fMax = lambda;
            while (Aceptaciones < n)
            {
                // Primer AGNA: genera x uniforme entre 0 y la cota
                double u1 = AGNA.NextDouble();
                double x = cota * u1;

                // Segundo AGNA: genera y uniforme entre 0 y lambda
                double u2 = AGNA.NextDouble();
                double y = fMax * u2;

                // Regla de aceptación
                if (y <= Densidad(x))
                {
                    Muestra[Aceptaciones] = x;
                    Aceptaciones++;
                }
            }
            
            return Muestra;
        }
    }
}




