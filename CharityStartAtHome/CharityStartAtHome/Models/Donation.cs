namespace CharityStartAtHome.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Donation : DbContext
    {
        public Donation()
            : base("name=Donation1")
        {
        }

        public virtual DbSet<Blood> Bloods { get; set; }
        public virtual DbSet<Cafe> Cafes { get; set; }
        public virtual DbSet<Cloth> Clothes { get; set; }
        public virtual DbSet<Viccharity> Viccharities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cafe>()
                .Property(e => e.Latitude)
                .HasPrecision(10, 6);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.Longitude)
                .HasPrecision(10, 6);

            modelBuilder.Entity<Cloth>()
                .Property(e => e.OpenTime)
                .IsUnicode(false);
        }
    }
}
