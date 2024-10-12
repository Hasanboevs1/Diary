using System.ComponentModel.DataAnnotations;
using Web.Models.Commons;

namespace Web.Models;

public class DiaryModel : Auditable
{
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Content { get; set; }

}
