using System;
using System.Collections.Generic;
using System.Linq;

namespace POS.Model
{
    /// <summary>
    /// ›«ò Ê— ›—Ê‘
    /// </summary>
    public class InvoiceSale
    {
        public long Id{ get; set; }
        public DateTime Date { get; set; }
        public decimal SumPrice
        {
            get
            {
                decimal sum =
                    InvoiceSaleUnits.Where(i => i.InputInvoice).Sum(j => j.ProductNumber * j.ProductUnit.ProductPrice) -
                    InvoiceSaleUnits.Where(i => !i.InputInvoice).Sum(j => j.ProductNumber * j.ProductUnit.ProductPrice);
                return sum;
            }
        }
        
        public virtual List<InvoiceSaleUnit> InvoiceSaleUnits { get; set; }

        public virtual Person Person { get; set; }
    }
}