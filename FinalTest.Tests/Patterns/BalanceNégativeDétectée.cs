using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    struct BalanceNégativeDétectée : IEvénementMétier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montant;
        private readonly DateTime _dateRetrait;

        public override string ToString()
        {
            return string.Format("NuméroDeCompte: {0}, Montant: {1}, DateRetrait: {2}", _numéroDeCompte, _montant, _dateRetrait);
        }

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montant = montant;
            _dateRetrait = dateRetrait;
        }
    }
}
