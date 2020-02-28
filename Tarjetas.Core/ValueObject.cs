using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Core
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        
        //private static readonly Member[] Members = GetMembers().ToArray();
        protected abstract bool CheckValidity(object value);
        /*
        public override bool Equals(object other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.GetType() == typeof(T) && Members.All(m =>
            {
                var otherValue = m.GetValue(other);
                var thisValue = m.GetValue(this);
                return m.IsNonStringEnumerable
                ? GetEnumerableValues(otherValue).SequenceEqual(GetEnumerableValues(thisValue))
                : (otherValue?.Equals(thisValue) ?? thisValue == null);
            });
        }
        */
    }
}
