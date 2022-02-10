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
        // Look for any records.
        if (context.Contact.Any())
        {
          return;   // DB has been seeded
        }
        context.Contact.AddRange(
        new Contact
        {
          Title = "Logistics Manager",
          NameFirst = "John",
          NameLast = "Smith",
          Email = "contact@company.com",
          Phone = "555-555-5555",
          CustomerId = "Company A",
          Location = ""
        }
        );

        // Look for any records.
        if (context.Customer.Any())
        {
          return;   // DB has been seeded
        }
        context.Customer.AddRange(
          new Customer
          {
            Name = "Bobcat",
            Team = "T108",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Dan VanAlstine",
            OpsLeader = "Burt Fosse",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Bobcat",
            Team = "T111",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Dan VanAlstine",
            OpsLeader = "Burt Fosse",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Bobcat",
            Team = "T226",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Dan VanAlstine",
            OpsLeader = "Burt Fosse",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Bobcat",
            Team = "T344",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Dan VanAlstine",
            OpsLeader = "Burt Fosse",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Bobcat",
            Team = "T427",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Dan VanAlstine",
            OpsLeader = "Burt Fosse",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Bobcat",
            Team = "T553",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Dan VanAlstine",
            OpsLeader = "Burt Fosse",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Daikin",
            Team = "T083",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Mark Griffith",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Daikin",
            Team = "T606",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Jan Trinh",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "FlexSteel",
            Team = "T099",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Retail"
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Salvador Campos",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "FlexSteel",
            Team = "T143",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lucas Wolfe",
            OpsLeader = "Dakota Eischied",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "FlexSteel",
            Team = "T144",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lucas Wolfe",
            OpsLeader = "Dakota Eischied",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "FlexSteel",
            Team = "T145",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lucas Wolfe",
            OpsLeader = "Dakota Eischied",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "FlexSteel",
            Team = "T148",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Ryan Brown",
            OpsLeader = "Mervin Petersen",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "FlexSteel",
            Team = "T246",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lucas Wolfe",
            OpsLeader = "Dakota Eischied",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Interstate Battery",
            Team = "T049",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Salvador Campos",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Interstate Battery",
            Team = "T598",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Ryan Brown",
            OpsLeader = "Mervin Petersen",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Safelite",
            Team = "T072",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Chris Fish",
            OpsLeader = "Dennis Munson II",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Safelite",
            Team = "T074",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Chris Fish",
            OpsLeader = "Dennis Munson II",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Safelite",
            Team = "T270",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Jeremy Howe",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Safelite",
            Team = "T272",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Chris Fish",
            OpsLeader = "Dennis Munson II",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Safelite",
            Team = "T562",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Chris Fish",
            OpsLeader = "Dennis Munson II",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Mission Foods",
            Team = "T077",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Other Food Grade"
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Salvador Campos",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Mission Foods",
            Team = "T147",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Food & Grocery"
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lance Cheney",
            OpsLeader = "Bryan Reiter",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Mission Foods",
            Team = "T437",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Food & Grocery"
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lance Cheney",
            OpsLeader = "Bryan Reiter",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Mission Foods",
            Team = "T444",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Food & Grocery"
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lance Cheney",
            OpsLeader = "Bryan Reiter",
            SalesRep = "Roger Mason",
            Executive = "Dan Van Alstine"
          },
          new Customer
          {
            Name = "Klockner Plentaplast",
            Team = "T097",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Jeremy Howe",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Klockner Plentaplast",
            Team = "T674",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Lucas Wolfe",
            OpsLeader = "Dakota Eischeid",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Klockner Plentaplast",
            Team = "T662",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Jeremy Howe",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Klockner Plentaplast",
            Team = "T744",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brad Gehring",
            OpsLeader = "Jeremy Howe",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Heidtman Steel",
            Team = "T101",
            CustomerTypeId = "Manage Trans",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Brett Schlegel",
            OpsLeader = "Jan Trinh",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Marmon Keystone",
            Team = "T106",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Clint Stockwell",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Marmon Keystone",
            Team = "T123",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Clint Stockwell",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Marmon Keystone",
            Team = "T156",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Clint Stockwell",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Marmon Keystone",
            Team = "T158",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Clint Stockwell",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Marmon Keystone",
            Team = "T170",
            CustomerTypeId = "Integrated Solutions",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Clint Stockwell",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          },
          new Customer
          {
            Name = "Midwest Pipe & Steel",
            Team = "T359",
            CustomerTypeId = "Dedicated",
            Url = "https://company.com",
            CommodityTypeId = "Manufacturing",
            Note = "ex:Renewal due for review 3/1/2023",
            VPO = "Robert Elkins",
            OpsLeader = "Mark Griffith",
            SalesRep = "Roger Mason",
            Executive = "Paul Jensen"
          }
        );

        if (context.CustomerType.Any())
        {
          return;   // DB has been seeded
        }
        context.CustomerType.AddRange(
          new CustomerType
          {
            Type = "IS",
            Description = "Integrated Solutions"
          },
          new CustomerType
          {
            Type = "ISNW",
            Description = "Integrated Solutions No Warehouse"
          },
          new CustomerType
          {
            Type = "MT",
            Description = "Managed Transportation"
          },
          new CustomerType
          {
            Type = "DCT",
            Description = "Dedicated"
          }
        );

        if (context.KpiType.Any())
        {
          return;   // DB has been seeded
        }
        context.KpiType.AddRange(
          new KpiType
          {
            Type = "Trans Mgmt Srvcs",
            Description = "Transportation Management Services"
          },
          new KpiType
          {
            Type = "ISNW",
            Description = "Integrated Solutions No Warehouse"
          },
          new KpiType
          {
            Type = "MT",
            Description = "Managed Transportation"
          },
          new KpiType
          {
            Type = "DCT",
            Description = "Dedicated"
          }
        );

        if (context.Question.Any())
        {
          return;   // DB has been seeded
        }
        context.Question.AddRange(
          new Question
          {
            Text = "Ruan's on-time delivery rate meets my expectations.",
            Type = "10-pt scale",
            Options = "",
            KpiType = "Transportation Management Services",
            CustomerTypeId = "IS"
          },
          new Question
          {
            Text = "Ruan's on-time delivery rate meets my expectations.",
            Type = "10-pt scale",
            Options = "",
            KpiType = "Transportation Management Services",
            CustomerTypeId = "MT"
          },
          new Question
          {
            Text = "Ruan's order fulfillment and inventory accuracy meet my expectations.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Warehousing Services"
          },
          new Question
          {
            Text = "Ruan's personnel are responsive and courteous.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Professionalism"
          },
          new Question
          {
            Text = "Safety is a key priority for Ruan.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Operation Priorities"
          },
          new Question
          {
            Text = "Ruan's drivers act according to my standards for reliability, integrity and appearance.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Professionalism"
          },
          new Question
          {
            Text = "Likelihood of recommending Ruan to business associate.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Recommendation and Referral"
          },
          new Question
          {
            Text = "Ruan proficiently manages our carrier Request For Proposal (RFP) events.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Transportation Management Services"
          },
          new Question
          {
            Text = "Ruan's order fulfillment and inventory accuracy meet my expectations.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Warehousing Services"
          },
          new Question
          {
            Text = "Ruan's team acts as an extension of our transportation team.",
            QuestionType = "10-pt scale",
            Options = null,
            KpiTypeId = "Transportation Management Services"
          }
        );
        context.SaveChanges();
      }
    }
  }
}