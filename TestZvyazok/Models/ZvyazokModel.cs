using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestZvyazok
{
    public partial class ZvyazokModel : DbContext
    {
        public ZvyazokModel()
            : base("name=ZvyazokModel")
        {
        }

        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<PersonalArea> PersonalAreas { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<TARIFF> TARIFFs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<PersonalArea>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<PersonalArea>()
                .HasOptional(e => e.USER)
                .WithRequired(e => e.PersonalArea);

            modelBuilder.Entity<Role>()
                .Property(e => e.Roles)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.USERs)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<USER>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Notes)
                .IsUnicode(false);

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
