using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    struct RetraitRéalisé : IEvénementMétier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montantRetrait;
        private readonly DateTime _dateRetrait;

        public override string ToString()
        {
            return string.Format("NuméroDeCompte: {0}, MontantRetrait: {1}, DateRetrait: {2}", _numéroDeCompte, _montantRetrait, _dateRetrait);
        }

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }
    }
}
