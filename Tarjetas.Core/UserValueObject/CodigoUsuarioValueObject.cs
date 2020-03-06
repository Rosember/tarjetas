using System;
namespace Tarjetas.Domain.UserValueObject
{
    public class CodigoUsuarioValueObject:ValueObject<CodigoUsuarioValueObject>
    {
        protected CodigoUsuarioValueObject() { }
        public string Value { get; internal set; }

        internal CodigoUsuarioValueObject(string value)
        {
            CheckValidity(value);
            Value = value;
        }

        public static CodigoUsuarioValueObject FromString(string value) => new CodigoUsuarioValueObject(value);
        protected override bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the user code");
            }
            string strValue = (string)value;

            if (strValue.Length > 50)
            {
                throw new ArgumentException("Can't be more than 50 characters long");
            }
            return true;
        }
    }
}
