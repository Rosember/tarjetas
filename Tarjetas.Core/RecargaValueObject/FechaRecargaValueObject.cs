using System;
namespace Tarjetas.Core.RecargaValueObject
{
    public class FechaRecargaValueObject:ValueObject<FechaRecargaValueObject>
    {
        private DateTime value;

        public FechaRecargaValueObject(DateTime value)
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
