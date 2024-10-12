using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.Commons;

public abstract class Auditable 
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
