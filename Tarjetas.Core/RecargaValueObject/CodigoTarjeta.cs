﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Domain.RecargaValueObject
{
    public class CodigoTarjeta:ValueObject<CodigoTarjeta>
    {
        protected CodigoTarjeta() { }
        public string Value { get; internal set; }

        internal CodigoTarjeta(string value)
        {
            CheckValidity(value);
            Value = value;
        }

        public static CodigoTarjeta FromString(string value) => new CodigoTarjeta(value);
        protected override bool CheckValidity(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Can't be an empty or null string the codigo");
            }
            string strValue = (string)value;

            if (strValue.Length > 14)
            {
                throw new ArgumentException("Can't be more than 14 characters long");
            }
            return true;
        }
    }
}
