using System;
namespace Tarjetas.Core.ClienteValueObject
{
    public class TelefonoClienteValueObject:ValueObject<TelefonoClienteValueObject>
    {

        protected TelefonoClienteValueObject() { }
        public string telefono { get; internal set; }

        internal TelefonoClienteValueObject(string telefono)
        {
            CheckValidity(telefono);
            this.telefono = telefono;
        }
        public static TelefonoClienteValueObject FromString(string value) => new TelefonoClienteValueObject(value);

        protected override bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the telefono");
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
