using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class InvoiceSaleConfig : EntityTypeConfiguration<InvoiceSale>
    {
        public InvoiceSaleConfig()
        {
            HasKey(i => i.Id);

            Ignore(i => i.SumPrice);

            HasMany(i => i.InvoiceSaleUnits)
                .WithRequired(j => j.InvoiceSale)
                .WillCascadeOnDelete(true);

            HasRequired(i => i.Person).WithMany(j => j.InvoiceSales);
        }
    }


    
}