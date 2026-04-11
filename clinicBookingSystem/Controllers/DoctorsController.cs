using clinicBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase
{
    private readonly ClinicDbContext _context;

    public DoctorsController(ClinicDbContext context)
    {
        _context = context;
    }
    // إضافة دكتور
    [HttpPost]
    public IActionResult AddDoctor(DoctorProfile doctor)
    {
        _context.DoctorProfiles.Add(doctor);
        _context.SaveChanges();
        return Ok(doctor);
    }
    // عرض كل الدكاترة
    [HttpGet]
    public IActionResult GetDoctors()
    {
        var doctors = _context.DoctorProfiles.ToList();
        return Ok(doctors);
    }
}
