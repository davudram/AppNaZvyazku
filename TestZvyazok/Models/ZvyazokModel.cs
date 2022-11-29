using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestZvyazok.Models
{
    public partial class ZvyazokModel : DbContext
    {
        public ZvyazokModel()
            : base("name=ZvyazokModel1")
        {
        }

        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<PersonalArea> PersonalAreas { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TARIFF> TARIFFs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.USERs)
                .WithRequired(e => e.Authorization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalArea>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.USERs)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TARIFF>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TARIFF>()
                .Property(e => e.Device)
                .IsUnicode(false);

            modelBuilder.Entity<TARIFF>()
                .Property(e => e.Notes)
                .IsUnicode(false);
        }
    }
}
