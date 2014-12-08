using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;

namespace POS.Repository.Mappers
{
    public class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            HasKey(i => i.Id);

            Ignore(i => i.SumPayments);
            Ignore(i => i.SumReceipts);
            Ignore(i => i.SumPaymentsCheck);
            Ignore(i => i.SumReceiptsCheck);
            Ignore(i => i.SumPaymentsNaghd);
            Ignore(i => i.SumReceiptsNaghd);
            
            
            HasMany(i => i.InvoiceBuys)
                .WithRequired(o => o.Person)
                .WillCascadeOnDelete(true);

            HasMany(i => i.InvoiceSales)
                .WithRequired(o => o.Person)
                .WillCascadeOnDelete(true);


            HasMany(i => i.Payments)
                .WithRequired(o => o.Person)
                .WillCascadeOnDelete(true);


            HasMany(i => i.Receipts)
                .WithRequired(o => o.Person)
                .WillCascadeOnDelete(true);

            
        }
    }
}
