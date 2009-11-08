using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortCalc.Lib.Common
{
    /// <summary>
    /// Represents different currencies
    /// </summary>
    public class Currency
    {
        private readonly String _name;
        private readonly int _numDecimalPlaces;
        private const int NO_ROUNDING = int.MaxValue;

        private Currency(String name, int numDecimalPlaces)
        {
            _name = name;
            _numDecimalPlaces = numDecimalPlaces;
        }

        public static readonly Currency UsDollars = new Currency("USD", 2);
        public static readonly Currency UsDollarsNoRounding = new Currency("USD", NO_ROUNDING);

        public String Name { get { return _name; }}
        public String Format(decimal value)
        {
            return String.Format("{0}{1}",
                                 _name,
                                 Round(value));
        }
        public decimal Round(decimal value)
        {
            if (_numDecimalPlaces != NO_ROUNDING)
                return Math.Round(value, _numDecimalPlaces);
            else
                return value;
        }
    }
}
