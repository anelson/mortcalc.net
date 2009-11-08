using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortCalc.Lib.AmortizedLoans
{
    /// <summary>
    /// A one-time additional payment on an amortization schedule
    /// </summary>
    public class AdditionalPayment
    {
        public int Ordinal { get; set;}
        public decimal Amount { get; set; }
    }
}
