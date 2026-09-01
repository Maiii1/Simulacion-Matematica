using System;

namespace SimESPOL
{
    public class EstimarSIM
    {
        public static double EstimarProbCondicional(int n, out double ProbCond)
        {
            Random AGNA = new Random();

            int NumEstBecas = 0;
            int NumEstBecasCiencias = 0;

            for (int i = 0; i < n; i++)
            {
                double Facultad = AGNA.NextDouble();
                double Beca = AGNA.NextDouble();

                // Facultad de Ciencias
                if (Facultad < 0.25)
                {
                    if (Beca < 0.60)
                    {
                        NumEstBecas++;
                        NumEstBecasCiencias++;
                    }
                }

                // Facultad de Ingeniería
                if (Facultad >= 0.25 && Facultad < 0.60)
                {
                    if (Beca < 0.40)
                    {
                        NumEstBecas++;
                    }
                }

                // Facultad de Humanidades
                if (Facultad >= 0.60)
                {
                    if (Beca < 0.15)
                    {
                        NumEstBecas++;
                    }
                }
            }

            double ProbBeca = (double)NumEstBecas / (double)n;

            ProbCond = (double)NumEstBecasCiencias / (double)NumEstBecas;

            return ProbBeca;
        }
        public double EstimarPI(int n)
        {
            int S = 0;
            Random AGNA = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = 2 * AGNA.NextDouble() - 1;
                double y = 2 * AGNA.NextDouble() - 1;

                if (x * x + y * y <= 1)
                {
                    S++;
                }
            }

            double estimacion = (4 * (double)S) / (double)n;
            return estimacion;
        }

        public int[,] JugarDados(int n, out int GP)
        {
            GP = 0;

            int[,] Jugadas = new int[n, 3];

            Random AGNA = new Random();

            for (int i = 0; i < n; i++)
            {
                int dado1 = AGNA.Next(1, 7);
                int dado2 = AGNA.Next(1, 7);

                Jugadas[i, 0] = dado1;
                Jugadas[i, 1] = dado2;

                if (dado1 == dado2)
                {
                    GP += 10;
                }

                if (Math.Abs(dado1 - dado2) == 1)
                {
                    GP += 5;
                }

                if (Math.Abs(dado1 - dado2) > 1)
                {
                    GP -= 2;
                }

                Jugadas[i, 2] = GP;
            }

            return Jugadas;
        }
        public double EstimarE(int n)
        {
            double estimacion = 0;
            Random AGNA = new Random();

            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                int j = 1;

                while (true)
                {
                    double num = AGNA.NextDouble();
                    suma += num;

                    if (suma > 1)
                    {
                        break;
                    }

                    j++;
                }

                estimacion += j;
            }

            return estimacion / (double)n;
        }
    }

}