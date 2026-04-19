using Microsoft.AspNetCore.Mvc;
using clinicBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase
{
    private readonly ClinicDbContext _context;

    public DoctorsController(ClinicDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var doctors = await _context.DoctorProfiles
            .Include(d => d.User)
            .Include(d => d.Specialty)
            .ToListAsync();

        return Ok(doctors);
    }
}
