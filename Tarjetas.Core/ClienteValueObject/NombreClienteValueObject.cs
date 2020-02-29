using System;
namespace Tarjetas.Core.ClienteValueObject
{
    public class NombreClienteValueObject:ValueObject<NombreClienteValueObject>
    {
        protected NombreClienteValueObject(){ }
        public string nombre { get; internal set; }

        internal NombreClienteValueObject(String nombre)
        {
            CheckValidity(nombre);
            this.nombre = nombre;
        }

        public static NombreClienteValueObject FromString(String value) => new NombreClienteValueObject(value);

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
