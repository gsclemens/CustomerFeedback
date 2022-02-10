using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFeedback.Models
{
  public class Customer
  {
    public int Id { get; set; }

    [Display(Name = "Company Name")]
    [MaxLength(100, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(100)")]
    public string Name { get; set; }

    [Display(Name = "Customer Type")]
    public int? CustomerTypeId { get; set; }

    [Display(Name = "Commodity Shipped")]
    public int? CommodityTypeId { get; set; }

    [MaxLength(1000, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(1000)")]
    public string? Note { get; set; }

    [Display(Name = "Company Contact Id")]
    public int? ContactId { get; set; }

    [Display(Name = "Company Website URL")]
    [MaxLength(200, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(200)")]
    [DataType(DataType.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// Navigation relationships
    /// </summary>

    public List<Contact>? Contacts { get; set; }
    public CommodityType? CommodityType { get; set; }
    public CustomerType? CustomerType { get; set; }

    /// <summary>
    /// 1:Many Relation: a Company has many Survey Responses,
    /// but an individual SR should have only one Customer & Client
    /// </summary>

    public List<SurveyResponse>? SurveyResponses { get; set; }
  }
}