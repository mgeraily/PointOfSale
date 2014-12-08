using System.Data.Entity.ModelConfiguration;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class CheckConfig : EntityTypeConfiguration<Check>
    {
        public CheckConfig()
        {
            HasKey(i => i.Id);

            HasOptional(i => i.Payment).WithOptionalPrincipal(i => i.Check);
            HasOptional(i => i.Receipt).WithOptionalPrincipal(i => i.Check);
        }
    }
}