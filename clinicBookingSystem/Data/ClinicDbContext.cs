using clinicBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
public class ClinicDbContext : DbContext
{
    public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
        : base(options)
    {
    }

  
    public DbSet<User> Users { get; set; }
    public DbSet<Specialty> Specialties { get; set; }

    public DbSet<DoctorProfile> DoctorProfiles { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}
