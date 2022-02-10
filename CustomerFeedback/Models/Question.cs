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
    [Column(TypeName = "VARCHAR(100)")]
    public int KpiTypeId { get; set; }

    [Display(Name = "Customer Type")]
    [Column(TypeName = "VARCHAR(100)")]
    public int CustomerTypeId { get; set; }

    /// <summary>
    /// Navigation classes
    /// </summary>

    public List<SurveyResponse>? SurveyResponses { get; set; }
    public List<SurveyQuestion>? SurveyQuestions { get; set; }
    public List<KpiType>? KpiType { get; set; }
    public CustomerType? CustomerType { get; set; }
  }
}