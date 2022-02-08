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
    /// Key Performance Indicators that each question is addressing (internal reference)
    /// e.g.; Professionalism, Value, Service, Warehouse, Satisfaction, etc.
    /// </summary>
    [Display(Name = "KPI")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? QuestionKpiType { get; set; }

    /// <summary>
    /// Navigation classes
    /// </summary>
    public List<SurveyResponse>? SurveyResponses { get; set; }

    public List<SurveyQuestion>? SurveyQuestions { get; set; }
  }
}