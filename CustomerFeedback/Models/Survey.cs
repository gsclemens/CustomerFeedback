using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class Survey
  {
    public int Id { get; set; }

    [StringLength(100, ErrorMessage = "{0} length must be between {2} and {1} characters long.", MinimumLength = 6)]
    [Column(TypeName = "VARCHAR(100)")]
    public string Title { get; set; }

    [Column(TypeName = "VARCHAR(250)")]
    public string? Description { get; set; }

    [Display(Name = "Created")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; }

    [Display(Name = "Expires")]
    [DataType(DataType.Date)]
    public DateTime? ExpireDate { get; set; }

    [Display(Name = "Created By")]
    public int? AdministratorId { get; set; }

    [Display(Name = "Customer Type")]
    public int CustomerTypeId { get; set; }

    /// <summary>
    /// Navigation classes
    /// </summary>

    public List<SurveyResponse>? SurveyResponses { get; set; }

    [InverseProperty("Survey")]
    public ICollection<SurveyQuestion>? SurveyQuestions { get; set; }

    public Administrator? Administrator { get; set; }
    public CustomerType? CustomerType { get; set; }
  }
}