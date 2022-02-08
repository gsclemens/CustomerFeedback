using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedback.Models.ViewModels
{
  public class SurveyAudienceVM
  {
    public List<Survey>? Surveys { get; set; }
    public SelectList? Audiences { get; set; }
    public string? SurveyAudience { get; set; }
    public string? SearchString { get; set; }
  }
}