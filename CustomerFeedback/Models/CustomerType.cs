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
    public string? Type { get; set; }

    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Description { get; set; }
  }
}