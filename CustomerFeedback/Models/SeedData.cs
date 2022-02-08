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
        // Look for any movies.
        if (context.Question.Any())
        {
          return;   // DB has been seeded
        }

        context.Question.AddRange(
          new Question
          {
            Text = "Ruan's on-time delivery rate meets my expectations.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Transportation Management Services"
          },
          new Question
          {
            Text = "Ruan's order fulfillment and inventory accuracy meet my expectations.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Warehousing Services"
          },
          new Question
          {
            Text = "Ruan's personnel are responsive and courteous.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Professionalism"
          },
          new Question
          {
            Text = "Safety is a key priority for Ruan.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Operation Priorities"
          },
          new Question
          {
            Text = "Ruan's drivers act according to my standards for reliability, integrity and appearance.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Professionalism"
          },
          new Question
          {
            Text = "Likelihood of recommending Ruan to business associate.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Recommendation and Referral"
          },
          new Question
          {
            Text = "Ruan proficiently manages our carrier Request For Proposal (RFP) events.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Transportation Management Services"
          },
          new Question
          {
            Text = "Ruan's order fulfillment and inventory accuracy meet my expectations.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Warehousing Services"
          },
          new Question
          {
            Text = "Ruan's team acts as an extension of our transportation team.",
            QuestionType = "10-point scale",
            Options = null,
            QuestionKpiType = "Transportation Management Services"
          }
        );
        context.SaveChanges();
      }
    }
  }
}