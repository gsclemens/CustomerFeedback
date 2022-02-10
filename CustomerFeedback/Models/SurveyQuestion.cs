using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class SurveyQuestion
  {
    public int Id { get; set; }
    public int? QuestionId { get; set; }
    public int? SurveyId { get; set; }
    public int? OrderId { get; set; }

    /// <summary>
    /// Navigation classes
    /// added FK attributes per getting error referenced in this SO post:
    /// https://stackoverflow.com/questions/58734118/to-resolve-this-configure-the-foreign-key-properties-explicitly-on-at-least-one
    /// </summary>

    [ForeignKey("QuestionId")]
    public virtual Question Question { get; set; }

    [ForeignKey("SurveyId")]
    public virtual Survey Survey { get; set; }
  }
}