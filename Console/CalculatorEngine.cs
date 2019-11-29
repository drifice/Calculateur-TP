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
        public virtual int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public virtual int Sub(int val1, int val2)
        {
            return val1 - val2;
        }

        public virtual int Mul(int val1, int val2)
        {
            return val1 * val2;
        }

        public virtual int Div(int val1, int val2)
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
        
    }
}
