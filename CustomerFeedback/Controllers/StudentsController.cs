using CustomerFeedback.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace CoreWithCSVHelper.Controllers
{
  public class StudentsController : Controller
  {
    [HttpGet]
    public IActionResult Index(List<Student> students = null)
    {
      students = students == null ? new List<Student>() : students;
      return View();
    }

    [HttpPost]
    public IActionResult Index(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
    {
      #region Upload CSV

      if (file == null) return View("Choose a file before submitting");

      string fileName = $"{ hostingEnvironment.WebRootPath }\\csvimport\\{file.FileName}";
      using (FileStream fileStream = System.IO.File.Create(fileName))
      {
        file.CopyTo(fileStream);
        fileStream.Flush();
      }

      #endregion Upload CSV

      var students = this.GetStudentList(file.FileName);
      return View("Index", students);
    }

    private List<Student> GetStudentList(string fileName)
    {
      List<Student> students = new List<Student>();

      #region Read CSV

      var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\csvimport"}" + "\\" + fileName;
      using (var reader = new StreamReader(path))
      using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
      {
        csv.Read();
        csv.ReadHeader();
        while (csv.Read())
        {
          var student = csv.GetRecord<Student>();
          students.Add(student);
        }
      }

      #endregion Read CSV

      #region Create CSV

      path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\csvexport"}";
      using (var write = new StreamWriter(path + "\\NewFile.csv"))
      using (var csv = new CsvWriter(write, CultureInfo.InvariantCulture))
      {
        csv.WriteRecords(students);
      }

      #endregion Create CSV

      return students;
    }
  }
}