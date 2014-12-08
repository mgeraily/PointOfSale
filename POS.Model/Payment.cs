using System;

namespace POS.Model
{
    /// <summary>
    /// پرداخت
    /// </summary>
    public class Payment
    {
        public long Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public virtual Person Person { get; set; }

        /// <summary>
        /// روش پرداخت
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// ارجاع به چک اگر روش پرداخت چک
        /// </summary>
        public virtual Check Check { get; set; }
    }
}