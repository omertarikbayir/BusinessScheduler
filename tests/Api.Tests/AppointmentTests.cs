using Xunit;
using BusinessScheduler.Api.Models;

public class AppointmentTests
{
    [Fact]
    public void Appointment_DefaultLanguage_IsEnglish()
    {
        var appt = new Appointment();
        Assert.Equal("en", appt.Language);
    }
}