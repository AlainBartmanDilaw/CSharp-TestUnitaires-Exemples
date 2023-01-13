using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class MathOperations
    {
        public int Fois(int a, int b)
        {
            return a * b;
        }

        public double Exposant(int a, int b)
        {
            return Math.Pow((double)a, (double)b);
        }

        public string[] splitThisString(string s)
        {
            return s.Split(';');
        }

    }
}
