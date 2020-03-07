using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Domain.RecargaValueObject
{
    public class MontoRecargaValueObject:ValueObject<MontoRecargaValueObject>
    {
        protected MontoRecargaValueObject() { }
        public decimal? Value { get; internal set; }

        internal MontoRecargaValueObject(decimal? value)
        {
            CheckValidity(value);
            Value = value;
        }

        public static MontoRecargaValueObject FromDecimal(decimal? value) => new MontoRecargaValueObject(value);
        protected override bool CheckValidity(object value)
        {

            if (value == null)
                throw new ArgumentException("Can't be an null value the codigo");

            decimal decimalValue = (decimal)value;

            if (decimalValue == 0)
                throw new ArgumentException("can't zero the amount");

            if (decimalValue < 0)
                throw new ArgumentException("cannot be less than zero in the amount");

            if (decimalValue > 500)
                throw new ArgumentException("can't enter amount greater than 500");

            return true;
        }
    }
}
