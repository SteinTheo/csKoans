using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.Linq
{
    class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                return from num in _keyValuePairs
                       where (num.Value % 2) == 0
                       select num.Value;
            }
        }

        public string TexteNombresImpairs
        {
            get
            {
                var keyValueImpairs = _keyValuePairs.OrderBy(val => val.Value);
                var tab = from num in keyValueImpairs
                          where (num.Value % 2) != 0
                          select num.Key;
                return tab.Aggregate((chaine, next) => chaine + ", " + next);
            }
        }

        public String PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                var keyValueImpairs = _keyValuePairs.OrderBy(val => val.Value);
                var tab = from num in keyValueImpairs
                          where num.Key.Length > 5
                          select num.Key;
                return tab.First();
            }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                var tab = from num in _keyValuePairs
                          where num.Value > 3
                          select num.Value;
                return tab.OrderBy(val => val).Take(4);
            }
        }
    }
}
