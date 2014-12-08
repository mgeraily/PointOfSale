using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            HasKey(i => i.Id);

            Ignore(i => i.NumberTotal);

        }
    }
}