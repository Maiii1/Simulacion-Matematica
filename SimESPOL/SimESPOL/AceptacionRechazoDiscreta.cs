using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimESPOL
{
    public class Poisson
    {
        public static double lambda;
        public static double Prob(int x)
        {
            double p = Math.Exp(-lambda);
            for (int i = 1; i <= x; i++)
            {
                p *= lambda / i;
            }
            return p;
        }
        public static BigInteger Fact(int x)
        {
            BigInteger F = 1;
            for (int i = 1; i <= x; i++)
            {
                F *= i;
            }
            return F;
        }
        public static int[] GetMuestra(int n, double p_min)
        {
            List<double> ProbPoisson = new List<double>();
            int x = 0;
            while (true)
            {
                double p = Poisson.Prob(x);
                if (p < p_min && x > Math.Floor(Poisson.lambda)) break;
                else
                {
                    ProbPoisson.Add(p);
                    x++;
                }
            }
            int[] Soporte = new int[ProbPoisson.Count];
            double[] Prob = new double[ProbPoisson.Count];
            for (int i = 0; i < ProbPoisson.Count(); i++)
            {
                Soporte[i] = i;
                Prob[i] = ProbPoisson[i];
            }
            AceptacionRechazoDiscreta obj = new AceptacionRechazoDiscreta(Soporte, Prob);
            int[] Muestra = obj.GetMuestra(n);
            return Muestra;
        }
    }
    public class AceptacionRechazoDiscreta
    {
        private int[] Soporte;
        private double[] Prob;
        private Random AGNA = new Random();

        public AceptacionRechazoDiscreta(int[] Soporte, double[] Prob)
        {
            this.Soporte = Soporte;
            this.Prob = Prob;
        }
        private double p_max()
        {
            double p = 0;
            int n = Prob.Length;
            for (int i = 0; i < n; i++)
            {
                if (Prob[i] > p) p = Prob[i];
            }
            return p;
        }
        public int[] GetMuestra(int n)
        {
            int[] Muestra = new int[n];
            int Aceptaciones = 0;
            double p = p_max();
            int k = Soporte.Length;
            while (true)
            {
                int lambda1 = AGNA.Next(1, k + 1);
                double lambda2 = AGNA.NextDouble();
                int x = Soporte[lambda1 - 1];
                double y = p * lambda2;
                if (y <= Prob[lambda1 - 1])
                {
                    Muestra[Aceptaciones] = x;
                    Aceptaciones++;
                }
                if (Aceptaciones == n) return Muestra;

            }
        }
    }
}