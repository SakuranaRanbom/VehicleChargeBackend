namespace VehicleChargeBackend.Models;

public class WorkOrderReply
{
    public Guid Id { get; set; }
    
    public Guid Reply_User_Id { get; set; }
    
    public string Content { get; set; }
    
    public Guid WO_Id { get; set; }
}