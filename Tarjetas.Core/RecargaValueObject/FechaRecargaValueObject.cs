using System;

namespace Tarjetas.Domain.RecargaValueObject
{
    public class FechaRecargaValueObject:ValueObject<FechaRecargaValueObject>
    {

        protected FechaRecargaValueObject() { }
        public DateTime value { get; internal set; }

        internal FechaRecargaValueObject(DateTime value)
        {
            CheckValidity(value);
            this.value = value;
        }

        public static FechaRecargaValueObject FromDate(DateTime value) => new FechaRecargaValueObject(value);
        protected override bool CheckValidity(object value)
        {
            if (value == null)
            {
                throw new ArgumentException("Can't be an null value the date");
            }
            return true;
        }
    }
}
