using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Model
{
    [ComplexType]
    public class ProductUnit
    {
        public long ProductId { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
    }
}