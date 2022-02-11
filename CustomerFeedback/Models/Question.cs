using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class Question
  {
    public int Id { get; set; }

    [Display(Name = "Question")]
    [Column(TypeName = "VARCHAR(1000)")]
    public string Text { get; set; }

    /// <summary>
    /// 10-point scale, Multi-choice, Comment
    /// </summary>
    [Display(Name = "Type")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? QuestionType { get; set; }

    [Display(Name = "Choices")]
    [Column(TypeName = "VARCHAR")]
    public string? Options { get; set; }

    /// <summary>
    /// Key Performance Indicators
    /// </summary>
    [Display(Name = "Key Performance Indicator")]
    public int KpiTypeId { get; set; }

    [Display(Name = "Customer Type")]
    public int CustomerTypeId { get; set; }

    /// <summary>
    /// Navigation classes
    /// </summary>

    public List<SurveyResponse>? SurveyResponses { get; set; }

    [InverseProperty("Question")]
    public ICollection<SurveyQuestion> SurveyQuestions { get; set; }

    public virtual List<KpiType>? KpiType { get; set; }
    public virtual CustomerType? CustomerType { get; set; }
  }
}