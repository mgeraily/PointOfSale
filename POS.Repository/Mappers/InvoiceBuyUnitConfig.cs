using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class InvoiceBuyUnitConfig : EntityTypeConfiguration<InvoiceBuyUnit>
    {
        public InvoiceBuyUnitConfig()
        {
            HasKey(i => i.Id);

            Property(p => p.ProductUnit.ProductId);
            Property(p => p.ProductUnit.ProductTitle);
            Property(p => p.ProductUnit.ProductPrice);

            HasRequired(i => i.InvoiceBuy).WithMany(j => j.InvoiceBuyUnits);
        }
    }
}