using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    interface ISynthèseCompteBancaireRepository
    {
        SynthèseCompteBancaire Get(string numeroDeCompte);
    }
}
