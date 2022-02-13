using CsvHelper.Configuration.Attributes;

namespace CustomerFeedback.Models
{
  public class Import
  {
    [Ignore]
    public int Id { get; set; }

    [Index(0)]
    [Name("Respondent ID")]
    public long? RespondentID { get; set; }

    [Index(1)]
    public int? CollectorID { get; set; }

    [Name("Email Address")]
    public string? EmailAddress { get; set; } = "";

    [Index(9)]
    [Name("Title")]
    public string? Title { get; set; } = "";

    [Index(10)]
    public string? Location { get; set; } = "";

    [Index(12)]
    [Name("A1")]
    public string? QuestionResponse1 { get; set; } = "";

    [Index(13)]
    [Name("A2")]
    public string? QuestionResponse2 { get; set; } = "";

    [Index(14)]
    [Name("A3")]
    public string? QuestionResponse3 { get; set; } = "";
  }
}