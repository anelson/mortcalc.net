﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortCalc.Lib.MortgageLoan
{
    /// <summary>
    /// Represents a single mortgage payment
    /// </summary>
    public class MortgageLoanPayment
    {
        /// <summary>
        /// Which payment this is, in order, starting with 1
        /// </summary>
        int Ordinal { get; set; }

        /// <summary>
        /// The part of this payment which pays down principal
        /// </summary>
        decimal Principal { get; set; }

        /// <summary>
        /// The part of this payment which pays interest
        /// </summary>
        decimal Interest { get; set;  }

        /// <summary>
        /// The part of this payment which covers property taxes
        /// </summary>
        decimal PropertyTaxes { get; set; }

        /// <summary>
        /// The part of this payment which covers homeowner's insurance
        /// </summary>
        decimal HomeownersInsurance { get; set; }

        /// <summary>
        /// The part of this payment which covers mortgage insurance
        /// </summary>
        decimal MortgageInsurance { get; set; }

        /// <summary>
        /// The part of this payment which covers any additional escrow account costs (like HOA dues)
        /// </summary>
        decimal AdditionalEscrowPayments { get; set; }

        /// <summary>
        /// The part of this payment which is above and beyond the required payment amount, used to pay down the principal more quickly
        /// </summary>
        decimal AdditionalPayment { get; set; }

        /// <summary>
        /// The total payment amount
        /// </summary>
        decimal PaymentAmount
        {
            get
            {
                return Principal +
                       Interest +
                       PropertyTaxes +
                       HomeownersInsurance +
                       MortgageInsurance +
                       AdditionalEscrowPayments +
                       AdditionalPayment;
            }
        }
    }
}