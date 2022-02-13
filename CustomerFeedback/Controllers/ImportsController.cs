using CustomerFeedback.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using CustomerFeedback.Data;
using Microsoft.EntityFrameworkCore;

namespace CustomerFeedback.Controllers
{
  public class ImportsController : Controller
  {
    private readonly CSATContext _context;

    public ImportsController(CSATContext context)
    {
      _context = context;
    }

    public List<Import> Imports { get; set; }

    [HttpGet]
    public IActionResult Index(List<Import> imports = null)
    {
      imports = imports == null ? new List<Import>() : imports;
      return View();
    }

    [HttpPost]
    public IActionResult Index(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
    {
      #region Upload CSV

      if (file == null) return NotFound("No file submitted. Make sure you are selecting a file for upload and try again.");

      string fileName = $"{ hostingEnvironment.WebRootPath }\\csvimport\\{file.FileName}";
      using (FileStream fileStream = System.IO.File.Create(fileName))
      {
        file.CopyTo(fileStream);
        fileStream.Flush();
      }

      #endregion Upload CSV

      var imports = this.GetImportList(file.FileName);
      return View("Index", imports);
    }

    private List<Import> GetImportList(string fileName)
    {
      List<Import> imports = new List<Import>();

      #region Read CSV

      var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\csvimport"}" + "\\" + fileName;
      using (var reader = new StreamReader(path))
      using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
      {
        csv.Read();
        csv.ReadHeader();
        while (csv.Read())
        {
          var import = csv.GetRecord<Import>();
          imports.Add(import);
        }
        Imports = imports;

        return imports;
      }

      #endregion Read CSV

      #region Create CSV

      path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\csvexport"}";
      using (var write = new StreamWriter(path + "\\NewFile.csv"))
      using (var csv = new CsvWriter(write, CultureInfo.InvariantCulture))
      {
        csv.WriteRecords(imports);
      }

      #endregion Create CSV

      return imports;
    }

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create(Imports)
    //{
    //  var imports = GetImportList();
    //  foreach (Import import in imports)
    //  {
    //    _context.Add(import);
    //    await _context.SaveChangesAsync();
    //    return RedirectToAction(nameof(Index));
    //  }
    //  return View(import);
    //}
  }
}