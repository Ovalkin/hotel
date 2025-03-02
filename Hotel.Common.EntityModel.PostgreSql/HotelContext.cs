using Hotel.Common.EntityModel.PostgreSql.Entities;
using Hotel.Common.EntityModel.PostgreSql.Enums;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Hotel.Common.EntityModel.PostgreSql;

using Microsoft.EntityFrameworkCore;

public partial class HotelContext : DbContext
{
    public HotelContext()
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<Booking>().ToTable("bookings");
        modelBuilder.Entity<Room>().ToTable("rooms");
        modelBuilder.Entity<Payment>().ToTable("payments");

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(b => b.UserId);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Room)
            .WithMany()
            .HasForeignKey(b => b.RoomId);

        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Booking)
            .WithMany()
            .HasForeignKey(p => p.BookingId);

        modelBuilder.Entity<Payment>()
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId);
        
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}