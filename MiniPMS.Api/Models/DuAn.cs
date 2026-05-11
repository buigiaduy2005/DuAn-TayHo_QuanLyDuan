using System.ComponentModel.DataAnnotations;

namespace MiniPMS.Api.Models;

public class DuAn
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string TenDuAn { get; set; } = string.Empty;
    
    public string MoTa { get; set; } = string.Empty;
    
    public DateTime NgayTao { get; set; } = DateTime.UtcNow;
}
