using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAPAPI.Web.Models
{
    public partial class lemon_dashboard_productionContext : DbContext
    {
        public lemon_dashboard_productionContext()
        {
        }

        public lemon_dashboard_productionContext(DbContextOptions<lemon_dashboard_productionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alias> Alias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=nfortics-maindb.chjfoptj7ci5.eu-central-1.rds.amazonaws.com;Database=lemon_dashboard_production;Username=nforticsmaster;Password=n4orticsmaster123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alias>(entity =>
            {
                entity.ToTable("alias");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.LoanAccountId);

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.SavingsAccountId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.LoanAccountId).HasColumnName("loan_account_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.SavingsAccountId).HasColumnName("savings_account_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });
        }
    }
}
