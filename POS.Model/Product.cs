using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Product
    {
        public long Id { get; set; }
        public string Group { get; set; }
        public string Title { get; set; }
        public decimal PriceBuy { get; set; }
        public decimal PriceSale { get; set; }
        public long NumberInStore { get; set; }
        public long NumberOfShop { get; set; }
        public long NumberTotal { get { return NumberInStore + NumberOfShop; } }
    }
}
