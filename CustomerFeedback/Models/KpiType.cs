using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class KpiType
  {
    ///KPI = Key Performance Indicator

    public int Id { get; set; }

    [Display(Name = "Key Perf. Indicator")]
    [MaxLength(10, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(10)")]
    public string Type { get; set; }

    [MaxLength(1000, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(1000)")]
    public string? Description { get; set; }
  }
}