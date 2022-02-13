#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerFeedback.Models;

namespace CustomerFeedback.Data
{
  public class CSATContext : DbContext
  {
    public CSATContext(DbContextOptions<CSATContext> options)
        : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  if (!optionsBuilder.IsConfigured)
    //  {
    //    optionsBuilder.UseSqlServer("Server=tcp:csatdb-sqlserver.database.windows.net,1433;Database=coreDB;User ID=kbunda;Password=IsThisComplexEnough22!!;Encrypt=true;Connection Timeout=30;");
    //  }
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<SurveyQuestion>()
      .HasOne(e => e.Survey)
      .WithMany()
      .OnDelete(DeleteBehavior.Restrict);

      modelBuilder.Entity<SurveyQuestion>()
        .HasOne(e => e.Question)
        .WithMany()
        .OnDelete(DeleteBehavior.Restrict);

      modelBuilder.Entity<SurveyResponse>()
        .HasOne(e => e.Survey)
        .WithMany()
        .OnDelete(DeleteBehavior.Restrict);

      modelBuilder.Entity<SurveyResponse>()
        .HasOne(e => e.Question)
        .WithMany()
        .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<Administrator> Administrator { get; set; }
    public DbSet<CommodityType> CommodityType { get; set; }
    public DbSet<Contact> Contact { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<CustomerType> CustomerType { get; set; }
    public DbSet<KpiType> KpiType { get; set; }
    public DbSet<Question> Question { get; set; }
    public DbSet<Import> Import { get; set; }
    public DbSet<Survey> Survey { get; set; }
    public DbSet<SurveyQuestion> SurveyQuestion { get; set; }
    public DbSet<SurveyResponse> SurveyResponse { get; set; }
  }
}