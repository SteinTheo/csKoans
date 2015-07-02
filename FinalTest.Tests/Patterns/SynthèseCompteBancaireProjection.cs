using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Patterns
{
    class SynthèseCompteBancaireProjection
    {
        private readonly ISynthèseCompteBancaireRepository _repository;

        public SynthèseCompteBancaireProjection(ISynthèseCompteBancaireRepository repository)
        {
            _repository = repository;
        }

        public void Handle(RetraitRéalisé retraitRéalisé)
        {
            _repository.Get(retraitRéalisé.NuméroDeCompte).AjouterDébit(retraitRéalisé.MontantRetrait);
        }
    }
}
