using Microsoft.AspNetCore.Mvc;
using BusinessScheduler.Api.Data;
using BusinessScheduler.Api.Models;

namespace BusinessScheduler.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly SchedulerDbContext _context;

    public AppointmentsController(SchedulerDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_context.Appointments.ToList());

    [HttpPost]
    public IActionResult Create(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetAll), new { id = appointment.Id }, appointment);
    }
}