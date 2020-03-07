using System;
using Tarjetas.Domain;

namespace Tarjetas.Core.RecargaValueObject
{
    public class EstadoTarjetaValueObject:ValueObject<EstadoTarjetaValueObject>
    {
        public EstadoTarjetaValueObject()
        {
        }
        public int Value { get; internal set; }

        internal EstadoTarjetaValueObject(int value)
        {
            CheckValidity(value);
            Value = value;
        }

        public static EstadoTarjetaValueObject FromInt(int value) => new EstadoTarjetaValueObject(value);
        protected override bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the codigo");
            }
            return true;
        }
    }
}
