using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.BasesCSharp
{
    class Somme : IOperation
    {
        public bool PeutCalculer(string s)
        {
            if (s.Contains("+"))
            {
                return true;
            }
            return false;
        }

        public int Calculer(string s)
        {

            var res = 0;
            if (PeutCalculer(s))
            {
                var tab = s.Split('+');
                foreach (var i in tab)
                {
                    res = res + Convert.ToInt32(i);
                }
                return res;
            }

            return -1;
        }
    }
}
