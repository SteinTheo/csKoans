using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    struct DépotRéalisé : IEvénementMétier
    {
        private string _numéroDeCompte;
        public Montant MontantDepot { get; private set; }
        private readonly DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot) : this()
        {
            _numéroDeCompte = numéroDeCompte;
            MontantDepot = montantDepot;
            _dateDepot = dateDepot;
        }
    }
}
