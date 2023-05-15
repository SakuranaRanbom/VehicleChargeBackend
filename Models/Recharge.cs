namespace VehicleChargeBackend.Models;

public class Recharge
{
    public Guid Id { get; set; }
    
    public Guid User_Id { get; set; }
    
    public int Count { get; set; }
    
    public string Method { get; set; }
    
    public DateTime Time { get; set; }
}