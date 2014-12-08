using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;
using POS.Repository.Mappers;

namespace POS.Repository.Context
{
    public class EfContext:DbContext,IUnitOfWork
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InvoiceBuy> InvoiceBuys { get; set; }
        public DbSet<InvoiceSale> InvoiceSales { get; set; }
        public DbSet<InvoiceBuyUnit> InvoiceBuyUnits { get; set; }
        public DbSet<InvoiceSaleUnit> InvoiceSaleUnits { get; set; }
        public DbSet<Payment> Payments{ get; set; }
        public DbSet<Receipt> Receipts{ get; set; }
        public DbSet<Check> Checks{ get; set; }


        public EfContext()
            : base("POSConnection")
        {
            Database.SetInitializer(new EfContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new InvoiceBuyConfig());
            modelBuilder.Configurations.Add(new InvoiceSaleConfig());
            modelBuilder.Configurations.Add(new InvoiceBuyUnitConfig());
            modelBuilder.Configurations.Add(new InvoiceSaleUnitConfig());
            modelBuilder.Configurations.Add(new PaymenyConfig());
            modelBuilder.Configurations.Add(new ReceiptConfig());
            modelBuilder.Configurations.Add(new CheckConfig());
        }


        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public int SaveAllChanges()
        {
            return base.SaveChanges();
        }

        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
