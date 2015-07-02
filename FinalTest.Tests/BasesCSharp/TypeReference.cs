using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests.BasesCSharp
{
    class TypeReference
    {
        public override int GetHashCode()
        {
            return _valInt;
        }

        private readonly int _valInt;

        public TypeReference(int valInt)
        {
            this._valInt = valInt;
        }

        // ReSharper disable once RedundantOverridenMember
        public override bool Equals(object obj)
        {
            return _valInt == ((TypeReference)obj)._valInt;
        }
    }
}
