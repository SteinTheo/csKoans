using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Tests.Patterns
{
    class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;
        private readonly DépotRéalisé _dépotRéalisé;

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            _compteCréé = compteCréé;
            _dépotRéalisé = dépotRéalisé;
        }

        public CompteBancaire(CompteCréé compteCréé)
        {
            _compteCréé = compteCréé;
        }

        public static IEnumerable<IEvénementMétier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvénementMétier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(_compteCréé.NuméroDeCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvénementMétier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            if (montantRetrait.Montant1 > _compteCréé.AutorisationDeCrédit + _dépotRéalisé.MontantDepot.Montant1)
            {
                throw new RetraitNonAutorisé();
            }

            yield return new RetraitRéalisé(_compteCréé.NuméroDeCompte, montantRetrait, dateRetrait);
            if (montantRetrait.Montant1 > _dépotRéalisé.MontantDepot.Montant1)
            {
                yield return new BalanceNégativeDétectée(_compteCréé.NuméroDeCompte, new Montant(montantRetrait.Montant1 - _dépotRéalisé.MontantDepot.Montant1), dateRetrait);
            }


        }
    }

    internal class RetraitNonAutorisé : Exception
    {
    }
}
