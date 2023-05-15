namespace VehicleChargeBackend.Models;

public class Appointment
{
    public Guid Id { get; set; }
    
    public string User_Id { get; set; }
    
    public string CE_Id { get; set; }
    
    public DateTime BeginTime { get; set; }
    
    public DateTime EndTime { get; set; }
}