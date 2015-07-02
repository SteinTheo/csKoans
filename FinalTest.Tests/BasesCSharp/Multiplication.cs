﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Tests.BasesCSharp
{
    class Multiplication
    {
        public int Calculer(string s)
        {
            var res = 1;
            if (PeutCalculer(s))
            {
                var tab = s.Split('*');
                foreach (var i in tab)
                {
                    res = res*Convert.ToInt32(i);
                }
                return res;
            }
            
            return -1;
        }

        public bool PeutCalculer(string s)
        {
            if (s.Contains("*"))
            {
                return true;
            }

            return false;
        }
    }
}
