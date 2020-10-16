using Microsoft.EntityFrameworkCore;

namespace AuroraAWS.WebApi.Models
{
    public partial class MetaDataDBContext : DbContext
    {
        public MetaDataDBContext()
        {
        }

        public MetaDataDBContext(DbContextOptions<MetaDataDBContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Aurora/MySql
                optionsBuilder.UseMySql("server=metadatacluster-instance-1.cbidsjnqo9ij.us-east-1.rds.amazonaws.com;database=MetaDataDB;uid=admin;pwd=Admin123*", x => x.ServerVersion("5.7.12-mysql"));

                // CrossTenancyDatabase
                // optionsBuilder.UseMySql("server=cross-tenancy-database-instance-1.ch00xfv5agd5.us-east-2.rds.amazonaws.com;database=CrossTenancyDatabase;uid=admin;pwd=Admin123*", x => x.ServerVersion("5.7.12-mysql"));

                // MySql
                // optionsBuilder.UseMySql("server=localhost;database=MetaDataMySQLDocker;uid=root;pwd=password", x => x.ServerVersion("8.0.20-mysql"));
            }
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<ExternalUserMap> ExternalUsersMap { get; set; }
        public DbSet<ExternalUserApplicationMap> ExternalUsersApplicationMap { get; set; }
    }
}
