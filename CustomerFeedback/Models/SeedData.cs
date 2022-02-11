using CustomerFeedback.Data;
using Microsoft.EntityFrameworkCore;

namespace CustomerFeedback.Models
{
  public class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new CSATContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<CSATContext>>()))
      {
        #region Contacts

        //Look for any records.
        if (context.Contact.Any())
        {
          return;   // DB has been seeded
        }
        context.Contact.AddRange(
          new Contact
          {
            Title = "North American Logistics Manager",
            NameFirst = "Russ",
            NameLast = "Smith",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 1,
            Location = "Bismarck, ND",
          },
          new Contact
          {
            Title = "VP of Procurement",
            NameFirst = "John",
            NameLast = "Wood",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 1,
            Location = "Gwinner,ND",
          },
          new Contact
          {
            Title = "Shipping Coordinator",
            NameFirst = "Evelyn",
            NameLast = "Irreguas",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 7,
            Location = "SAN LUIS POTOSI, MEXICO"
          },
          new Contact
          {
            Title = "Business Development Manager",
            NameFirst = "Josh",
            NameLast = "Dotson",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 30,
            Location = "Toledo, OH"
          },
          new Contact
          {
            Title = "Direct of Resource Planning",
            NameFirst = "Darlene",
            NameLast = "Dotson",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 30,
            Location = "Erie, MI"
          },
          new Contact
          {
            Title = "Vice President",
            NameFirst = "Tim",
            NameLast = "Janssen",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 38,
            Location = "Des Moines, IA"
          },
          new Contact
          {
            Title = "Sales Manager",
            NameFirst = "Bob",
            NameLast = "Dole",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 36,
            Location = "Fort Wayne, IN"
          },
          new Contact
          {
            Title = "Director",
            NameFirst = "Trampas",
            NameLast = "Goodmanson",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 1,
            Location = "West Fargo"
          },
          new Contact
          {
            Title = "Shipping Coordinator",
            NameFirst = "Evelyn",
            NameLast = "Irreguas",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 7,
            Location = "SAN LUIS POTOSI, MEXICO"
          },
          new Contact
          {
            Title = "Comptroller",
            NameFirst = "Herb",
            NameLast = "Sutton",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 37,
            Location = "Ankeny,IA"
          },
          new Contact
          {
            Title = "VP Logistics and Parts",
            NameFirst = "Barb",
            NameLast = "Soja",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 31,
            Location = "Southampton,MA"
          },
          new Contact
          {
            Title = "Supply Chain Manager",
            NameFirst = "Aaron",
            NameLast = "Ross",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 28,
            Location = "Rural Retreat,VA"
          },
          new Contact
          {
            Title = "Regional Transportation Manager",
            NameFirst = "Ashley",
            NameLast = "Roberts",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 23,
            Location = "Dallas,TX"
          },
          new Contact
          {
            Title = "Director of Materials Mgt & Logistics",
            NameFirst = "John",
            NameLast = "Kemp",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 19,
            Location = "Columbus,OH"
          },
          new Contact
          {
            Title = "VP Logistics and Parts",
            NameFirst = "Tony",
            NameLast = "Hayden",
            Email = "contact@company.com",
            Phone = "555-555-5555",
            CustomerId = 12,
            Location = "Dubuque,IA"
          }
        );

        #endregion Contacts

        #region Customers

        //if (context.Customer.Any())
        //{
        //  return;   // DB has been seeded
        //}
        //context.Customer.AddRange(
        //  new Customer
        //  {
        //    Name = "Bobcat",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 1,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Daikin",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 1,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "FlexSteel",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 2,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Interstate Battery",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 3,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Safelite",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 3,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Mission Foods",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 4,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Klockner Plentaplast",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 1,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Heidtman Steel",
        //    CustomerTypeId = 7,
        //    Url = "https://company.com",
        //    CommodityTypeId = 1,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Marmon Keystone",
        //    CustomerTypeId = 5,
        //    Url = "https://company.com",
        //    CommodityTypeId = 1,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Midwest Pipe & Steel",
        //    CustomerTypeId = 8,
        //    Url = "https://company.com",
        //    CommodityTypeId = 1,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "State of Iowa - Alchoholic Beverage Divison",
        //    CustomerTypeId = 6,
        //    Url = "https://company.com",
        //    CommodityTypeId = 5,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  },
        //  new Customer
        //  {
        //    Name = "Rasmussen Group",
        //    CustomerTypeId = 8,
        //    Url = "https://company.com",
        //    CommodityTypeId = 3,
        //    Note = "ex:Renewal due for review 3/1/2023"
        //  }
        //);

        #endregion Customers

        #region Questions

        //if (context.Question.Any())
        //{
        //  return;   // DB has been seeded
        //}
        //context.Question.AddRange(
        //  new Question
        //  {
        //    Text = "Ruan's on-time delivery rate meets my expectations.",
        //    Type = "10-pt scale",
        //    Options = "",
        //    KpiType = "Transportation Management Services",
        //    CustomerTypeId = "IS"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan's on-time delivery rate meets my expectations.",
        //    Type = "10-pt scale",
        //    Options = "",
        //    KpiType = "Transportation Management Services",
        //    CustomerTypeId = "MT"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan's order fulfillment and inventory accuracy meet my expectations.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Warehousing Services"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan's personnel are responsive and courteous.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Professionalism"
        //  },
        //  new Question
        //  {
        //    Text = "Safety is a key priority for Ruan.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Operation Priorities"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan's drivers act according to my standards for reliability, integrity and appearance.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Professionalism"
        //  },
        //  new Question
        //  {
        //    Text = "Likelihood of recommending Ruan to business associate.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Recommendation and Referral"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan proficiently manages our carrier Request For Proposal (RFP) events.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Transportation Management Services"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan's order fulfillment and inventory accuracy meet my expectations.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Warehousing Services"
        //  },
        //  new Question
        //  {
        //    Text = "Ruan's team acts as an extension of our transportation team.",
        //    QuestionType = "10-pt scale",
        //    Options = null,
        //    KpiTypeId = "Transportation Management Services"
        //  }
        //);

        #endregion Questions

        #region Administrators

        //if (context.Administrator.Any())
        //{
        //  return; // DB has been seeded
        //}
        //context.Administrator.AddRange(
        //new Administrator
        //{
        //  EmpId = "DVANALST",
        //  Title = "Executive",
        //  NameFirst = "Dan",
        //  NameLast = "Van Alstine",
        //  Email = "dvanalst@company.com",
        //  Phone = "515-555-5432"
        //},
        //new Administrator
        //{
        //  EmpId = "PAJENSEN",
        //  Title = "Executive",
        //  NameFirst = "Paul",
        //  NameLast = "Jensen",
        //  Email = "pajensen@company.com",
        //  Phone = "515-555-4321"
        //},
        //new Administrator
        //{
        //  EmpId = "BRREITER",
        //  Title = "Operations Leader",
        //  NameFirst = "Bryan",
        //  NameLast = "Reiter",
        //  Email = "brreiter@company.com",
        //  Phone = "515-555-3210"
        //},
        //new Administrator
        //{
        //  EmpId = "BURFOSSE",
        //  Title = "Operations Leader",
        //  NameFirst = "Burt",
        //  NameLast = "Fosse",
        //  Email = "BURFOSSE@company.com",
        //  Phone = "515-555-6543"
        //},
        //new Administrator
        //{
        //  EmpId = "CSTOCKWE",
        //  Title = "Operations Leader",
        //  NameFirst = "Clint",
        //  NameLast = "Stockwell",
        //  Email = "CSTOCKWE@company.com",
        //  Phone = "515-555-0000"
        //},
        //new Administrator
        //{
        //  EmpId = "DEISCHEI",
        //  Title = "Operations Leader",
        //  NameFirst = "Dakota",
        //  NameLast = "Eischeid",
        //  Email = "DEISCHEI@company.com",
        //  Phone = "515-555-1111"
        //},
        //new Administrator
        //{
        //  EmpId = "DEMUNSON",
        //  Title = "Operations Leader",
        //  NameFirst = "Dennis",
        //  NameLast = "Munson II",
        //  Email = "DEMUNSON@company.com",
        //  Phone = "515-555-9876"
        //},
        //new Administrator
        //{
        //  EmpId = "JANTRINH",
        //  Title = "Operations Leader",
        //  NameFirst = "Jan Jan",
        //  NameLast = "Trinh",
        //  Email = "JANTRIHN@company.com",
        //  Phone = "515-555-8520"
        //},
        //new Administrator
        //{
        //  EmpId = "JEREHOWE",
        //  Title = "Operations Leader",
        //  NameFirst = "Jeremy",
        //  NameLast = "Howe",
        //  Email = "JEREHOWE@company.com",
        //  Phone = "515-555-0258"
        //},
        //new Administrator
        //{
        //  EmpId = "MGRIFFIT",
        //  Title = "Operations Leader",
        //  NameFirst = "Mark",
        //  NameLast = "Griffith",
        //  Email = "MGRIFFIT@company.com",
        //  Phone = "515-555-9541"
        //},
        //new Administrator
        //{
        //  EmpId = "MPETERSE",
        //  Title = "Operations Leader",
        //  NameFirst = "Mervin",
        //  NameLast = "Petersen",
        //  Email = "MPETERSE@company.com",
        //  Phone = "515-555-7845"
        //},
        //new Administrator
        //{
        //  EmpId = "SACAMPOS",
        //  Title = "Operations Leader",
        //  NameFirst = "Salvador",
        //  NameLast = "Campos",
        //  Email = "SACAMPOS@company.com",
        //  Phone = "515-555-9710"
        //},
        //new Administrator
        //{
        //  EmpId = "ROGMASON",
        //  Title = "Sales Representative",
        //  NameFirst = "Roger",
        //  NameLast = "Mason",
        //  Email = "ROGMASON@company.com",
        //  Phone = "515-555-8332"
        //},
        //new Administrator
        //{
        //  EmpId = "BGEHRING",
        //  Title = "VPO",
        //  NameFirst = "Brad",
        //  NameLast = "Gehring",
        //  Email = "BGEHRING@company.com",
        //  Phone = "515-555-9654"
        //},
        //new Administrator
        //{
        //  EmpId = "BSCHLEGE",
        //  Title = "VPO",
        //  NameFirst = "Brett",
        //  NameLast = "Schlegel",
        //  Email = "BSCHLEGE@company.com",
        //  Phone = "515-555-5588"
        //},
        //new Administrator
        //{
        //  EmpId = "CHRIFISH",
        //  Title = "VPO",
        //  NameFirst = "Chris",
        //  NameLast = "FISH",
        //  Email = "CHRIFISH@company.com",
        //  Phone = "515-555-7788"
        //},
        //new Administrator
        //{
        //  EmpId = "LACHENEY",
        //  Title = "VPO",
        //  NameFirst = "Lance",
        //  NameLast = "Cheney",
        //  Email = "LACHENEY@company.com",
        //  Phone = "515-555-9911"
        //},
        //new Administrator
        //{
        //  EmpId = "LUCWOLFE",
        //  Title = "VPO",
        //  NameFirst = "Lucas",
        //  NameLast = "Wolfe",
        //  Email = "LUCWOLFE@company.com",
        //  Phone = "515-555-2244"
        //},
        //new Administrator
        //{
        //  EmpId = "ROELKINS",
        //  Title = "VPO",
        //  NameFirst = "Bob",
        //  NameLast = "Elkins",
        //  Email = "ROELKINS@company.com",
        //  Phone = "515-555-6622"
        //},
        //new Administrator
        //{
        //  EmpId = "RYABROWN",
        //  Title = "VPO",
        //  NameFirst = "Ryan",
        //  NameLast = "Brown",
        //  Email = "RYABROWN@company.com",
        //  Phone = "515-555-4411"
        //},
        //new Administrator
        //{
        //  EmpId = "KBUNDA",
        //  Title = "Applications Developer",
        //  NameFirst = "Kris",
        //  NameLast = "Bunda",
        //  Email = "kbunda@company.com",
        //  Phone = "515-555-5555"
        //},
        //new Administrator
        //{
        //  EmpId = "EDIKEMAN",
        //  Title = "Scrum Master & IT Business Analyst",
        //  NameFirst = "Emily",
        //  NameLast = "Dikeman",
        //  Email = "edikeman@company.com",
        //  Phone = "515-555-4444"
        //},
        //new Administrator
        //{
        //  EmpId = "GCLEMENS",
        //  Title = "IT Architect",
        //  NameFirst = "Gen",
        //  NameLast = "Clemens",
        //  Email = "gclemens@company.com",
        //  Phone = "515-555-3333"
        //},
        //new Administrator
        //{
        //  EmpId = "ASNYDER",
        //  Title = "Intern",
        //  NameFirst = "Alan",
        //  NameLast = "Snyder",
        //  Email = "asnyder@company.com",
        //  Phone = "515-555-6666"
        //}
        //);

        #endregion Administrators

        #region TypeTables

        //if (context.CommodityType.Any())
        //{
        //  return;   // DB has been seeded
        //}
        //context.CommodityType.AddRange(
        //  new CommodityType
        //  {
        //    Type = "Manufacturing",
        //    Description = "Manufacturing"
        //  },
        //  new CommodityType
        //  {
        //    Type = "Retail",
        //    Description = "Retail"
        //  },
        //  new CommodityType
        //  {
        //    Type = "Other",
        //    Description = "Other"
        //  },
        //  new CommodityType
        //  {
        //    Type = "Other Food Grade",
        //    Description = "Other Food Grade"
        //  },
        //  new CommodityType
        //  {
        //    Type = "Food & Grocery",
        //    Description = "Food & Grocery"
        //  },
        //  new CommodityType
        //  {
        //    Type = "Finished Goods",
        //    Description = "Finished Goods"
        //  }
        //);

        //if (context.KpiType.Any())
        //{
        //  return;   // DB has been seeded
        //}
        //context.KpiType.AddRange(
        //  new KpiType
        //  {
        //    Type = "Ruan Fleet Management",
        //    Description = "Ruan Fleet Management Services"
        //  },
        //  new KpiType
        //  {
        //    Type = "Supply Chain - Logistics Solutions",
        //    Description = "Ruan Supply Chain Solutions Services - Logistics Solutions"
        //  },
        //  new KpiType
        //  {
        //    Type = "Supply Chain - Warehouse",
        //    Description = "Ruan Supply Chain Solutions Services - Warehouse and Manufacturing"
        //  },
        //  new KpiType
        //  {
        //    Type = "Professionalism",
        //    Description = "Professionalism"
        //  },
        //  new KpiType
        //  {
        //    Type = "Communication",
        //    Description = "Communication"
        //  },
        //  new KpiType
        //  {
        //    Type = "Customer Service",
        //    Description = "Customer Service"
        //  },
        //  new KpiType
        //  {
        //    Type = "Operational Priorities",
        //    Description = "Operational Priorities"
        //  },
        //  new KpiType
        //  {
        //    Type = "Overall Performance",
        //    Description = "Overall Performance"
        //  },
        //  new KpiType
        //  {
        //    Type = "Recommendation Referral",
        //    Description = "Recommendation Referral"
        //  },
        //  new KpiType
        //  {
        //    Type = "Ruan Transportation Management Systems",
        //    Description = "Ruan Transportation Management Systems"
        //  },
        //  new KpiType
        //  {
        //    Type = "Value",
        //    Description = "Value"
        //  },
        //  new KpiType
        //  {
        //    Type = "Warehouse and Manufacturing Services",
        //    Description = "Warehouse and Manufacturing Services"
        //  },
        //  new KpiType
        //  {
        //    Type = "Additional Feedback",
        //    Description = "Additional Feedback"
        //  }
        //);

        //if (context.CustomerType.Any())
        //{
        //  return;   // DB has been seeded
        //}
        //context.CustomerType.AddRange(
        //  new CustomerType
        //  {
        //    Type = "IS",
        //    Description = "Integrated Solutions"
        //  },
        //  new CustomerType
        //  {
        //    Type = "ISNW",
        //    Description = "Integrated Solutions No Warehouse"
        //  },
        //  new CustomerType
        //  {
        //    Type = "MT",
        //    Description = "Managed Transportation"
        //  },
        //  new CustomerType
        //  {
        //    Type = "DCT",
        //    Description = "Dedicated Partnership"
        //  }
        //);

        #endregion TypeTables

        context.SaveChanges();
      }
    }
  }
}