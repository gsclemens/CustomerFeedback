using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class Administrator
  {
    public int Id { get; set; }

    [Display(Name = "Employee ID")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(20)")]
    public string? EmpId { get; set; }

    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? Title { get; set; }

    [Display(Name = "First Name")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(50)")]
    public string NameFirst { get; set; }

    [Display(Name = "Last Name")]
    [MaxLength(50, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(50)")]
    public string NameLast { get; set; }

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
    /// </summary>

    public List<Survey>? Surveys { get; set; }
  }
}