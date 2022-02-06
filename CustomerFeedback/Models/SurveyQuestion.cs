namespace CustomerFeedback.Models
{
  public class SurveyQuestion
  {
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public int SurveyId { get; set; }
    public int? OrderId { get; set; }

    /// <summary>
    /// Navigation classes
    /// </summary>
    public Question Question { get; set; }

    public Survey Survey { get; set; }
  }
}