using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class PaymenyConfig : EntityTypeConfiguration<Payment>
    {
        public PaymenyConfig()
        {
            HasKey(i => i.Id);

            HasRequired(i => i.Person).WithMany(j => j.Payments);
            HasOptional(i => i.Check).WithOptionalDependent(j => j.Payment);
            
        }
    }
}