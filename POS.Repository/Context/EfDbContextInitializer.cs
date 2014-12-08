using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Repository.Migrations;

namespace POS.Repository.Context
{
    public class EfContextInitializer : MigrateDatabaseToLatestVersion<EfContext, Configuration> //DropCreateDatabaseIfModelChanges<EfDbContext>
    {

        public override void InitializeDatabase(EfContext context)
        {
            //InitializeIdentityForEF(context);
            base.InitializeDatabase(context);
        }




    }
}
