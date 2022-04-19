using TPFinal.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace TPFinal.DAL.EntityFramework
{
    public class DataContextConfiguration: DbConfiguration
    {


        public DataContextConfiguration()
        {
            this.SetDatabaseInitializer(new CreateDatabaseIfNotExists<DataContext>());
            this.SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }

    }
}