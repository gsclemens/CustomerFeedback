using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class CustomerType
  {
    public int Id { get; set; }

    [Display(Name = "Company Type")]
    [MaxLength(10, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(10)")]
    public string Type { get; set; }

    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Description { get; set; }

    /// <summary>
    /// Navigation relationships
    /// These are 1:many because each CustomerType category has (describes) many
    /// Customers, Questions, and Surveys, but those do not each have many CustomerType categories.
    /// </summary>

    public virtual List<Customer>? Customers { get; set; }
    public virtual List<Question>? Questions { get; set; }
    public virtual List<Survey>? Surveys { get; set; }
  }
}