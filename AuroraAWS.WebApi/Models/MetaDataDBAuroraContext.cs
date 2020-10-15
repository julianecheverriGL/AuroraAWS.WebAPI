using Microsoft.EntityFrameworkCore;

namespace AuroraAWS.WebApi.Models
{
    public partial class MetaDataDBAuroraContext : DbContext
    {
        public MetaDataDBAuroraContext()
        {
        }

        public MetaDataDBAuroraContext(DbContextOptions<MetaDataDBAuroraContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Aurora/MySql
                // optionsBuilder.UseMySql("server=metadatacluster-instance-1.ciwawmmpzleq.us-east-1.rds.amazonaws.com;database=MetaDataDBAurora;uid=admin;pwd=Admin123*", x => x.ServerVersion("5.7.12-mysql"));

                // CrossTenancyDatabase
                // optionsBuilder.UseMySql("server=cross-tenancy-database-instance-1.ch00xfv5agd5.us-east-2.rds.amazonaws.com;database=CrossTenancyDatabase;uid=admin;pwd=Admin123*", x => x.ServerVersion("5.7.12-mysql"));

                // MySql
                optionsBuilder.UseMySql("server=localhost;database=MetaDataMySQLDocker;uid=root;pwd=password", x => x.ServerVersion("8.0.20-mysql"));
            }
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<AssociationPerson> AssociationsPersons { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Association>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("id")
        //            .HasColumnType("int(11)");

        //        entity.Property(e => e.Address)
        //            .IsRequired()
        //            .HasColumnName("address")
        //            .HasColumnType("varchar(45)")
        //            .HasCharSet("latin1")
        //            .HasCollation("latin1_swedish_ci");

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasColumnName("name")
        //            .HasColumnType("varchar(150)")
        //            .HasCharSet("latin1")
        //            .HasCollation("latin1_swedish_ci");
        //    });

        //    modelBuilder.Entity<Person>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("id")
        //            .HasColumnType("int(11)");

        //        entity.Property(e => e.Email)
        //            .IsRequired()
        //            .HasColumnName("email")
        //            .HasColumnType("varchar(50)")
        //            .HasCharSet("latin1")
        //            .HasCollation("latin1_swedish_ci");

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasColumnName("name")
        //            .HasColumnType("varchar(100)")
        //            .HasCharSet("latin1")
        //            .HasCollation("latin1_swedish_ci");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
