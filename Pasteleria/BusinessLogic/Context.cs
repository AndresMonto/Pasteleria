using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Pasteleria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pasteleria.BusinessLogic
{
    public class Context : DbContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Gallery> Gallery { get; set; }

        public Context() : base()
        {
        }

        public static string GetStringConexion() {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "eu-az-sql-serv1.database.windows.net";
            builder.InitialCatalog = "dsfrxzfyg13tt63";
            builder.IntegratedSecurity = false;
            builder.MultipleActiveResultSets = true;
            builder.UserID = "uswxq1kddwsc6j9";
            builder.Password = "jPO17O&eYAL7rMY$etOkF$R&A";
            builder.UserInstance = false;
            builder.ConnectTimeout = 0;
            builder.Pooling = true;

            return builder.ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetStringConexion())
                     //.ConfigureWarnings(x => x.Throw(RelationalEventId.QueryClientEvaluationWarning))
                     //.EnableSensitiveDataLogging(HCore.EntornoDesarrollo)
                     .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}