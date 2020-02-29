using System;
namespace Tarjetas.Core.UserValueObject
{
    public class PasswordUserValueObject:ValueObject<PasswordUserValueObject>
    {
        protected PasswordUserValueObject() { }
        public string Value { get; internal set; }

        internal PasswordUserValueObject(string value)
        {
            CheckValidity(value);
            Value = value;
        }

        public static PasswordUserValueObject FromString(string value) => new PasswordUserValueObject(value);
        protected override bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the user password");
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
