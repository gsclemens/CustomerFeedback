using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class CommodityType
  {
    ///Commodity = the type of goods or services our customers ship

    [Display(Name = "Key Perf. Indicator")]
    [MaxLength(20, ErrorMessage = "{0} max length is {1} characters, please enter a short name for the type, and a more elaborate explanation for the description.")]
    [Column(TypeName = "VARCHAR(20)")]
    public string Type { get; set; }

    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Description { get; set; }
  }
}