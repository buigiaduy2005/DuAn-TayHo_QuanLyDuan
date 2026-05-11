using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniPMS.Api.Models;

public class CongViec
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string TieuDe { get; set; } = string.Empty;
    
    [Required]
    public string TrangThai { get; set; } = "Todo"; // Gồm: Todo, Doing, Done
    
    public int DuAnId { get; set; }
    
    [ForeignKey("DuAnId")]
    public DuAn? DuAn { get; set; }
}
