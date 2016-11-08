namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=LetsGo")
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Flights> Flights { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.Total_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Value)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Discount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flights>()
                .Property(e => e.Company_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Flights>()
                .Property(e => e.Departure_Airport)
                .IsUnicode(false);

            modelBuilder.Entity<Flights>()
                .Property(e => e.Arrival_Airport)
                .IsUnicode(false);

            modelBuilder.Entity<Flights>()
                .Property(e => e.Starting_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Flights>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Flights)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
