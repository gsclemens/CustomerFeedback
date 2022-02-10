using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class CommodityType
  {
    ///Commodity = the type of goods or services our customers ship
    public int Id { get; set; }

    [Display(Name = "Key Perf. Indicator")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters, please enter a short name for the type, and a more elaborate explanation for the description.")]
    [Column(TypeName = "VARCHAR(50)")]
    public string Type { get; set; }

    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Description { get; set; }

    /// <summary>
    /// Navigation relationships
    /// These are 1:many because each CommodityType category has (describes) many
    /// Customers, but those Customers do not each have many CommodityType categories.
    /// </summary>

    public List<Customer>? Customers { get; set; }
  }
}