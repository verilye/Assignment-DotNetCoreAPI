using Microsoft.EntityFrameworkCore;
using FinalAssignment.Models;

namespace FinalAssignment.Data;

public class RoomBookingContext : DbContext{
    public RoomBookingContext(DbContextOptions<RoomBookingContext> options) : base(options){}
    public DbSet<Booking> Bookings{get;set;}
    public DbSet<Room> Rooms{get;set;}
    public DbSet<Staff> Staff{get;set;}
}