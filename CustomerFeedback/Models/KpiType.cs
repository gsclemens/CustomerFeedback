using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class KpiType
  {
    ///KPI = Key Performance Indicator

    public int Id { get; set; }

    [Display(Name = "Key Perf. Indicator")]
    [MaxLength(250, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(250)")]
    public string Type { get; set; }

    [MaxLength(1000, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(1000)")]
    public string? Description { get; set; }

    /// <summary>
    /// Navigation relationships
    /// These are 1:many because each KpiType category has (describes) many
    /// Customers, but those Customers do not each have many KpiType categories.
    /// </summary>

    public List<Customer>? Customers { get; set; }
  }
}