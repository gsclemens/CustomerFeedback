using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class Customer
  {
    public int Id { get; set; }

    [Display(Name = "Company Name")]
    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Name { get; set; }

    [MaxLength(1000, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(1000)")]
    public string? Note { get; set; }

    [Display(Name = "Customer Type")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(50)")]
    public string? Type { get; set; }

    [Display(Name = "Company Website URL")]
    [MaxLength(200, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(200)")]
    [DataType(DataType.Url)]
    public string? Url { get; set; }

    [Display(Name = "Company Phone")]
    [MaxLength(20, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(20)")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    [Display(Name = "Company Contact Id")]
    public int ContactId { get; set; }

    public List<Contact>? Contacts { get; set; }
  }
}