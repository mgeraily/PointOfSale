using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class InvoiceBuyConfig : EntityTypeConfiguration<InvoiceBuy>
    {
        public InvoiceBuyConfig()
        {
            HasKey(i => i.Id);

            Ignore(i => i.SumPrice);

            HasMany(i => i.InvoiceBuyUnits)
                .WithRequired(j => j.InvoiceBuy)
                .WillCascadeOnDelete(true);

            HasRequired(i => i.Person).WithMany(j => j.InvoiceBuys);
        }
    }

}