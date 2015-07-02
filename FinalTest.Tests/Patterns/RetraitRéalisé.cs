using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    struct RetraitRéalisé : IEvénementMétier
    {
        public string NuméroDeCompte { get; private set; }
        public Montant MontantRetrait { get; private set; }
        private readonly DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
            : this()
        {
            NuméroDeCompte = numéroDeCompte;
            MontantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }
    }
}
