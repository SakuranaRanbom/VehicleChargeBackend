namespace VehicleChargeBackend.Models;

public class ChargeEquipment
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Addr { get; set; }
    
    public string Mobile { get; set; }
    public string Lat { get; set; }
    
    public string Lng { get; set; }
    
    public string User { get; set; }
    
    public int Status { get; set; }
}