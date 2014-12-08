using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class InvoiceSaleUnitConfig : EntityTypeConfiguration<InvoiceSaleUnit>
    {
        public InvoiceSaleUnitConfig()
        {
            HasKey(i => i.Id);

            Property(p => p.ProductUnit.ProductId);
            Property(p => p.ProductUnit.ProductTitle);
            Property(p => p.ProductUnit.ProductPrice);

            HasRequired(i => i.InvoiceSale).WithMany(j => j.InvoiceSaleUnits);
        }
    }
}