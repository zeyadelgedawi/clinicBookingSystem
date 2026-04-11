using clinicBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly ClinicDbContext _context;

    public AppointmentsController(ClinicDbContext context)
    {
        _context = context;
    }
    // حجز موعد
    [HttpPost]
    public IActionResult Book(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        _context.SaveChanges();
        return Ok(appointment);
    }
    // عرض كل الحجوزات
    [HttpGet]
    public IActionResult GetAll()
    {
        var appointments = _context.Appointments.ToList();
        return Ok(appointments);
    }
}