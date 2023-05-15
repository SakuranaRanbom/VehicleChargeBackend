namespace VehicleChargeBackend.Models;

public class Charge
{
    public Guid ID { get; set; }
    
    public DateTime BeginTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public int Balance { get; set; }
    
    public Guid CE_Id { get; set; }
    
    public Guid User_Id { get; set; }
    
    
}