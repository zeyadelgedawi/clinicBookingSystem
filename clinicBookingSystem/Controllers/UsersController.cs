using Microsoft.AspNetCore.Mvc;
using clinicBookingSystem.Models;
using System.Runtime.InteropServices;

namespace clinicBookingSystem.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ClinicDbContext _context;

    public UsersController(ClinicDbContext context)
    {
        _context = context;
    }
    // تسجيل مستخدم جديد
    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }
    // عرض كل المستخدمين
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }
}