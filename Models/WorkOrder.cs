namespace VehicleChargeBackend.Models;

public class WorkOrder
{
    public Guid Id { get; set; }
    
    public Guid User_Id { get; set; }
    
    public int Priority { get; set; }
    
    public string Title { get; set; }
    
    public string Content { get; set; }
    
    public int Status { get; set; }
    
    public Guid Replyer_Id { get; set; }
    
    
}