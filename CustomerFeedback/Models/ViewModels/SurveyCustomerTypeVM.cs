using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedback.Models.ViewModels
{
  public class SurveyCustomerTypeVM
  {
    public List<Survey>? Surveys { get; set; }
    public SelectList? CustomerTypes { get; set; }
    public string? SurveyCustomerType { get; set; }
    public string? SearchString { get; set; }
  }
}