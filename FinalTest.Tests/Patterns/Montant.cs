using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    public struct Montant
    {
        public override string ToString()
        {
            return string.Format("Montant1: {0}", Montant1);
        }

        public int Montant1 { get; private set; }

        public Montant(int montant)
            : this()
        {
            Montant1 = montant;
        }
    }
}
