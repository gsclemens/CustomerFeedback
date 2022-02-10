using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class Contact
  {
    public int Id { get; set; }

    [Display(Name = "Company")]
    public int CustomerId { get; set; }

    [Display(Name = "Type")]
    public int CustomerTypeId { get; set; }

    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Title { get; set; }

    [MaxLength(1000, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(1000)")]
    public string? Note { get; set; }

    [Display(Name = "First Name")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(50)")]
    public string? NameFirst { get; set; }

    [Display(Name = "Last Name")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(50)")]
    public string? NameLast { get; set; }

    [MaxLength(200, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(200)")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [MaxLength(20, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(20)")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    /// <summary>
    /// Navigation relationships

    public Customer? Customer { get; set; }
    public CustomerType? CustomerType { get; set; }
    public List<SurveyResponse>? SurveyResponses { get; set; }
  }
}