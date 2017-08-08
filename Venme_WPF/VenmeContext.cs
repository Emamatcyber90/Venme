using System.Data.Entity;

namespace Venme.Models
{
    public partial class VenmeContext : DbContext
    {
        public VenmeContext()
            : base("name=VenmeContext")
        {
        }

        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
