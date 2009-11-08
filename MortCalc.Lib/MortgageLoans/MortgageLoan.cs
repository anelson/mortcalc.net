using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortCalc.Lib.Mortgage
{
    /// <summary>
    /// Contains the parameters that define a particular set of mortgage terms
    /// </summary>
    public class MortgageLoan 
    {
        /// <summary>
        /// The total sale price of the property
        /// </summary>
        decimal PurchasePrice { get; set; }

        /// <summary>
        /// The amount of the purchase price provided up front as a down payment
        /// </summary>
        decimal DownPayment { get; set; }

        /// <summary>
        /// The rate of interest in the loan.  A value of 0.055 represents an interest rate of 5.5%, for example
        /// </summary>
        decimal InterestRate { get; set; }

        /// <summary>
        /// The total number of payments to be made before the loan is paid off.
        /// 
        /// Usually mortgage payments are monthly, so this value is the term of the mortgage in years times 12.
        /// Common terms are 15 and 30 years.
        /// </summary>
        int NumPayments { get; set; }

        /// <summary>
        /// The property tax per payment, expressed as a fixed currency amount.  If property tax is 1200/yr, and
        /// payments are monthly, this value would be 100.
        /// 
        /// NB: This is pretty stupid, since property tax won't remain a fixed amount over 30 years, both due to flucutations
        /// in the property's assessed value, and changes in the property tax rate.
        /// </summary>
        decimal PropertyTax { get; set; }

        /// <summary>
        /// The Homeowners insurance per payment, as a fixed currency amount.  If insurance is 1200/yr, and
        /// payments are monthly, this value would be 100.
        /// </summary>
        decimal HomeownersInsurance { get; set; }

        /// <summary>
        /// The mortgage insurance (PMI) per payment, as a fixed currency amount.  If PMI is 1200/yr, and
        /// payments are monthly, this value would be 100.
        /// </summary>
        decimal MortgageInsurance { get; set; }

        /// <summary>
        /// The additional amount to add to each monthly payment due to other costs paid out of the mortgage escrow account.
        /// For example, flood insurance, HOA dues, etc.
        /// </summary>
        decimal AdditionalEscrowPayments { get; set; }

        /// <summary>
        /// Additional money paid with each payment over and above the required amount.  Used to pay off the principal faster
        /// so as to reduce total interest payments over time
        /// </summary>
        decimal AdditionalPayment { get; set; }
    }
}
