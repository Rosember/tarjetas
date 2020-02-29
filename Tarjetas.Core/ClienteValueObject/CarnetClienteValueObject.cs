using System;
namespace Tarjetas.Core.ClienteValueObject
{
    public class CarnetClienteValueObject:ValueObject<CarnetClienteValueObject>
    {
        protected CarnetClienteValueObject() { }
        public string ci { get; internal set; }

        internal CarnetClienteValueObject(string value)
        {
            CheckValidity(ci);
            ci = value;
        }

        public static CarnetClienteValueObject FromString(string value) => new CarnetClienteValueObject(value);

        protected override bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the name");
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
