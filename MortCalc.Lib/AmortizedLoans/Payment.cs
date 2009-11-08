using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortCalc.Lib.AmortizedLoans
{
    /// <summary>
    /// A single payment on an amortized loan
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Which payment this is, in order, starting with 1
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// The part of this payment which pays down principal
        /// </summary>
        public decimal Principal { get; set; }

        /// <summary>
        /// The part of this payment which pays interest
        /// </summary>
        public decimal Interest { get; set; }

        /// <summary>
        /// An additional payment over and above what's required, which goes toward paying down principal
        /// </summary>
        public decimal AdditionalPayment { get; set; }

        /// <summary>
        /// The amount of principal remaining on the loan after this payment
        /// </summary>
        public decimal OutstandingPrincipal { get; set; }

        /// <summary>
        /// The total payment amount
        /// </summary>
        public decimal TotalPayment
        {
            get
            {
                return Principal + Interest + AdditionalPayment;
            }
        }
    }
}