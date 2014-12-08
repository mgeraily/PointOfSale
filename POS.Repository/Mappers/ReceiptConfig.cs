using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class ReceiptConfig : EntityTypeConfiguration<Receipt>
    {
        public ReceiptConfig()
        {
            HasKey(i => i.Id);

            HasRequired(i => i.Person).WithMany(j => j.Receipts);
            HasOptional(i => i.Check).WithOptionalDependent(j => j.Receipt);

        }
    }
}