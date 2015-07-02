using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    public struct SynthèseCompteBancaire
    {
        public string NuméroDeCompte { get; private set; }
        private int _debits;
        private readonly int _credits;

        public SynthèseCompteBancaire(string numéroDeCompte, int debits, int credits) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            _debits = debits;
            _credits = credits;
        }

        public void AjouterDébit(Montant montantRetrait)
        {
            _debits += montantRetrait.Montant1;
        }
    }
}
