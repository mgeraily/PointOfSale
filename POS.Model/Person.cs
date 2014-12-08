using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }

        
        /// <summary>
        /// لیست فاکتورهای خرید از این فرد خاص
        /// </summary>
        public virtual List<InvoiceBuy> InvoiceBuys { get; set; }

        /// <summary>
        /// لیست فاکتورهای فروش به این فرد خاص
        /// </summary>
        public virtual List<InvoiceSale> InvoiceSales { get; set; }


        /// <summary>
        /// جمع دریافتی ها
        /// </summary>
        public decimal SumReceipts { get { return Receipts.Sum(i => i.Price); } }

        /// <summary>
        /// جمع پرداخت ها
        /// </summary>
        public decimal SumPayments { get { return Payments.Sum(i => i.Price); } }

        /// <summary>
        /// جمع دریافتی ها نقدی
        /// </summary>
        public decimal SumReceiptsNaghd { get { return Receipts.Where(i=>i.PaymentMethod==PaymentMethod.Naghd).Sum(i => i.Price); } }

        /// <summary>
        /// جمع پرداخت ها نقدی
        /// </summary>
        public decimal SumPaymentsNaghd { get { return Payments.Where(i=>i.PaymentMethod==PaymentMethod.Naghd).Sum(i => i.Price); } }


        /// <summary>
        /// جمع دریافتی ها چکی
        /// </summary>
        public decimal SumReceiptsCheck { get { return Receipts.Where(i=>i.PaymentMethod==PaymentMethod.Check).Sum(i => i.Price); } }

        /// <summary>
        /// جمع پرداخت ها چکی
        /// </summary>
        public decimal SumPaymentsCheck { get { return Payments.Where(i=>i.PaymentMethod==PaymentMethod.Check).Sum(i => i.Price); } }

        /// <summary>
        /// دریافت ها
        /// </summary>
        public virtual List<Receipt> Receipts { get; set; }

        /// <summary>
        /// پرداخت ها
        /// </summary>
        public virtual List<Payment> Payments { get; set; }
    }
}
