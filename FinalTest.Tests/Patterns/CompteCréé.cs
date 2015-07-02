using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    struct CompteCréé : IEvénementMétier
    {
        public string NuméroDeCompte { get; private set; }
        public int AutorisationDeCrédit { get; private set; }

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            AutorisationDeCrédit = autorisationDeCrédit;
        }
    }
}
