using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Domain.UserValueObject
{
    public class NameUser
    {
        protected NameUser() { }
        public string Value { get; internal set; }

        internal NameUser(string value)
        {
            CheckValidity(value);
            Value = value;
        }

        public static NameUser FromString(string value) => new NameUser(value);
        protected  bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the name");
            }
            string strValue = (string)value;

            if (strValue.Length > 100)
            {
                throw new ArgumentException("Can't be more than 100 characters long");
            } 
            return true;
        }
    }
}
