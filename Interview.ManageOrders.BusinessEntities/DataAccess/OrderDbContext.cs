
using Interview.ManageOrders.BusinessEntities.Models;
using System.Data.Entity;


namespace Interview.ManageOrders.BusinessEntities.DataAccess
{
    /// <summary>
    /// Context class
    /// </summary>
    public class OrderDbContext : DbContext
    {
        public OrderDbContext() : base("OrderDbCon") { }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrders { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.AccountNumber)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerName)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .HasMany(e => e.ServiceOrders)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceOrder>()
                .Property(e => e.LastUpdatedBy)
                .IsFixedLength();

            modelBuilder.Entity<ServiceType>()
                .Property(e => e.ServiceName)
                .IsFixedLength();

            modelBuilder.Entity<ServiceType>()
                .HasMany(e => e.ServiceOrders)
                .WithRequired(e => e.ServiceType)
                .WillCascadeOnDelete(false);
        }
    }
}