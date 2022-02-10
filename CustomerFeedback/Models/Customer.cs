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

    [Display(Name = "Team #")]
    [MaxLength(8, ErrorMessage = "{0} max length is {1} characters.")]
    [Column(TypeName = "VARCHAR(8)")]
    public string Team { get; set; }

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
    /// Pull id values from Administrator Table with a lookup column for each of the next 4 roles
    /// </summary>

    [Display(Name = "VP Operations")]
    public int? VPO { get; set; }

    [Display(Name = "Ops Leader")]
    public int? OpsLeader { get; set; }

    [Display(Name = "Sales Rep")]
    public int? SalesRep { get; set; }

    public int? Executive { get; set; }

    /// <summary>
    /// Navigation relationships
    /// </summary>

    public List<Contact>? Contacts { get; set; }
    public List<CommodityType>? CommodityTypes { get; set; }
    public List<CustomerType>? CustomerTypes { get; set; }
    public List<Administrator>? Administrators { get; set; }
  }
}