using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleChargeBackend.Models;

public class User
{
    
    public Guid Id { get; set; }
    [Key]
    public string Name { get; set; }
    
    public string Image { get; set; }
    
    public string Passwd { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedTime { get; set; }
}