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

    [Display(Name = "Question Type")]
    [Column(TypeName = "VARCHAR(100)")]
    public string? QuestionType { get; set; }

    [Display(Name = "Multiple Choice Options")]
    [Column(TypeName = "VARCHAR")]
    public string? Options { get; set; }

    /// <summary>
    /// Navigation classes
    /// </summary>
    public List<SurveyResponse> SurveyResponses { get; set; }

    public List<SurveyQuestion> SurveyQuestions { get; set; }
  }
}