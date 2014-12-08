namespace POS.Model
{
    /// <summary>
    /// قلم فاکتور های فاکتور فروش
    /// </summary>
    public class InvoiceBuyUnit
    {
        public long Id { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public long ProductNumber { get; set; }
        
        /// <summary>
        /// مشخض کننده این است که قلم مورد نظر در فاکتور قرار گرفت
        /// </summary>
        public bool InputInvoice { get; set; }

        /// <summary>
        /// مشخض کننده این است که قلم مورد نظر از فاکتور خارج شد
        /// </summary>
        public bool OutputInvoice { get { return !InputInvoice; } }


        public virtual InvoiceBuy InvoiceBuy { get; set; }
    }
}