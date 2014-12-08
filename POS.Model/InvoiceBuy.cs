using System;
using System.Collections.Generic;
using System.Linq;

namespace POS.Model
{
    /// <summary>
    /// فاکتور خرید
    /// </summary>
    public class InvoiceBuy
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }

        public decimal SumPrice
        {
            get
            {
                decimal sum =
                    InvoiceBuyUnits.Where(i => i.InputInvoice).Sum(j => j.ProductNumber*j.ProductUnit.ProductPrice) -
                    InvoiceBuyUnits.Where(i => !i.InputInvoice).Sum(j => j.ProductNumber*j.ProductUnit.ProductPrice);
                
                return sum;
            }
        }

        public virtual List<InvoiceBuyUnit> InvoiceBuyUnits { get; set; }

        public virtual Person Person { get; set; }
    }
}