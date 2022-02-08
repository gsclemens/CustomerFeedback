using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedback.Models.ViewModels
{
  public class SurveyResponseCustomerVM
  {
    public List<SurveyResponse>? Surveys { get; set; }
    public SelectList? Customers { get; set; }
    public string? SurveyResponseCustomer { get; set; }
    public string? SearchString { get; set; }
  }
}