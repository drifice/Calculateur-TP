using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine

    {
        /// <summary>
        /// fonction additionner
        /// </summary>
        /// <param name="val1">la 1er valeur</param>
        /// <param name="val2">la 2eme valeur</param>
        /// <returns>le resultat de l'addiction</returns>
        public virtual int Addition(int val1, int val2)
        {
            return val1 + val2;
        }

        public virtual int Substraction(int val1, int val2)
        {
            return val1 - val2;
        }

        public virtual int Multiplication(int val1, int val2)
        {
            return val1 * val2;
        }
        public virtual int Division(int val1, int val2)
        {
            int res;
            if (val2 != 0)
            {
                res = val1 / val2;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }

        public virtual double SquareRoot(int val1)
        {
            double res = Math.Sqrt(val1);

            return res;
        }


        public virtual double Square(double val1)
        {
            double res= Math.Pow(val1, 2);
            return res;
        }

        public virtual double Persentage(double val1)
        {
            double res = val1 / 100;
            return res;
        }
    }
}
