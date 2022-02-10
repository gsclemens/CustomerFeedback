using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class SurveyResponse
  {
    public int Id { get; set; }

    [Display(Name = "Survey ID")]
    public int? SurveyId { get; set; }

    [Display(Name = "Question ID")]
    public int? QuestionId { get; set; }

    [Display(Name = "Survey Assignee")]
    public int? ContactId { get; set; }

    [Display(Name = "Customer Assignee")]
    public int? CustomerId { get; set; }

    [Display(Name = "Multiple Choice Options")]
    [Column(TypeName = "VARCHAR(2000)")]
    public string? Answer { get; set; }

    [Display(Name = "Question Score")]
    [Range(0, 100)]
    public int? QuestionScore { get; set; }

    [Display(Name = "Survey Iteration")]
    public DateTime? SurveyResponseIteration { get; set; }

    /// <summary>
    /// Navigation classes
    /// The reason both Contact and Customer are referenced is: the business mentioned
    /// there are times when a survey is returned without a contact ID, as it may have been
    /// forwarded by another employee and returned anonymously. Having the CustomerId is a fallback then.
    /// </summary>

    [ForeignKey("SurveyId")]
    public Survey Survey { get; set; }

    [ForeignKey("QuestionId")]
    public Question Question { get; set; }

    public Contact? Contact { get; set; }
    public Customer? Customer { get; set; }
  }
}