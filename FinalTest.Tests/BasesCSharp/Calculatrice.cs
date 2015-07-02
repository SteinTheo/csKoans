using System.Linq;

namespace FinalTest.Tests.BasesCSharp
{
    class Calculatrice
    {
        private IOperation[] io;
        public Calculatrice(IOperation[] operations)
        {
            io = operations;
        }

        public int Calculer(string s)
        {
            int res;
            res = -1;

            if (s.Contains('*'))
            {
                var mul = new Multiplication();
                res = mul.Calculer(s);
            }

            if (s.Contains('+'))
            {
                var sum = new Somme();
                res = sum.Calculer(s);
            }

            
            return res;
        }
    }

    internal interface IOperation
    {
    }
}
