#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CustomerFeedback.Data;
using CustomerFeedback.Models;
using CustomerFeedback.Models.ViewModels;

namespace CustomerFeedback.Controllers
{
  public class SurveyResponsesController : Controller
  {
    private readonly CSATContext _context;

    public SurveyResponsesController(CSATContext context)
    {
      _context = context;
    }

    //GET: SurveyResponses
    public async Task<IActionResult> Index()
    {
      var cSATContext = _context.SurveyResponse.Include(s => s.Contact).Include(s => s.Question).Include(s => s.Survey);
      return View(await cSATContext.ToListAsync());
    }

    // GET: SurveyResponses
    //public async Task<IActionResult> Index(string surveyResponseCustomer, string searchString)
    //{
    //  // Use LINQ to get list of customers.
    //  IQueryable<string> customerQuery = from m in _context.SurveyResponse
    //                                     orderby m.Customer
    //                                     select m.Customer;
    //  var surveyResponses = from m in _context.SurveyResponse
    //                        select m;

    //  if (!string.IsNullOrEmpty(searchString))
    //  {
    //    surveyResponses = surveyResponses.Where(s => s.Title!.Contains(searchString));
    //  }

    //  if (!string.IsNullOrEmpty(surveyResponseCustomer))
    //  {
    //    surveyResponses = surveyResponses.Where(x => x.Customer == surveyResponseCustomer);
    //  }

    //  var surveyResponseCustomerVM = new SurveyResponseCustomerVM
    //  {
    //    Customers = new SelectList(await customerQuery.Distinct().ToListAsync()),
    //    SurveyResponses = await surveyResponses.ToListAsync()
    //  };

    //  return View(surveyResponseCustomerVM);
    //}

    // GET: SurveyResponses/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var surveyResponse = await _context.SurveyResponse
          .Include(s => s.Contact)
          .Include(s => s.Question)
          .Include(s => s.Survey)
          .FirstOrDefaultAsync(m => m.Id == id);
      if (surveyResponse == null)
      {
        return NotFound();
      }

      return View(surveyResponse);
    }

    // GET: SurveyResponses/Create
    public IActionResult Create()
    {
      ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id");
      ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id");
      ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id");
      return View();
    }

    // POST: SurveyResponses/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,SurveyId,QuestionId,ContactId,Answer,QuestionScore,SurveyResponseIteration")] SurveyResponse surveyResponse)
    {
      if (ModelState.IsValid)
      {
        _context.Add(surveyResponse);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id", surveyResponse.ContactId);
      ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", surveyResponse.QuestionId);
      ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id", surveyResponse.SurveyId);
      return View(surveyResponse);
    }

    // GET: SurveyResponses/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var surveyResponse = await _context.SurveyResponse.FindAsync(id);
      if (surveyResponse == null)
      {
        return NotFound();
      }
      ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id", surveyResponse.ContactId);
      ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", surveyResponse.QuestionId);
      ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id", surveyResponse.SurveyId);
      return View(surveyResponse);
    }

    // POST: SurveyResponses/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,SurveyId,QuestionId,ContactId,Answer,QuestionScore,SurveyResponseIteration")] SurveyResponse surveyResponse)
    {
      if (id != surveyResponse.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(surveyResponse);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!SurveyResponseExists(surveyResponse.Id))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return RedirectToAction(nameof(Index));
      }
      ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id", surveyResponse.ContactId);
      ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", surveyResponse.QuestionId);
      ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id", surveyResponse.SurveyId);
      return View(surveyResponse);
    }

    // GET: SurveyResponses/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var surveyResponse = await _context.SurveyResponse
          .Include(s => s.Contact)
          .Include(s => s.Question)
          .Include(s => s.Survey)
          .FirstOrDefaultAsync(m => m.Id == id);
      if (surveyResponse == null)
      {
        return NotFound();
      }

      return View(surveyResponse);
    }

    // POST: SurveyResponses/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var surveyResponse = await _context.SurveyResponse.FindAsync(id);
      _context.SurveyResponse.Remove(surveyResponse);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool SurveyResponseExists(int id)
    {
      return _context.SurveyResponse.Any(e => e.Id == id);
    }
  }
}