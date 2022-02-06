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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CSATdb;Trusted_Connection=True;MultipleActiveResultSets=true");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<Administrator> Administrator { get; set; }

    public DbSet<Customer> Customer { get; set; }

    public DbSet<Contact> Contact { get; set; }

    public DbSet<Question> Question { get; set; }

    public DbSet<SurveyQuestion> SurveyQuestion { get; set; }

    public DbSet<Survey> Survey { get; set; }

    public DbSet<SurveyResponse> SurveyResponse { get; set; }
  }
}