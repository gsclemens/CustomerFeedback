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

namespace CustomerFeedback.Controllers
{
    public class SurveyQuestionsController : Controller
    {
        private readonly CSATContext _context;

        public SurveyQuestionsController(CSATContext context)
        {
            _context = context;
        }

        // GET: SurveyQuestions
        public async Task<IActionResult> Index()
        {
            var cSATContext = _context.SurveyQuestion.Include(s => s.Question).Include(s => s.Survey);
            return View(await cSATContext.ToListAsync());
        }

        // GET: SurveyQuestions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyQuestion = await _context.SurveyQuestion
                .Include(s => s.Question)
                .Include(s => s.Survey)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surveyQuestion == null)
            {
                return NotFound();
            }

            return View(surveyQuestion);
        }

        // GET: SurveyQuestions/Create
        public IActionResult Create()
        {
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id");
            ViewData["SurveyId"] = new SelectList(_context.Set<Survey>(), "Id", "Id");
            return View();
        }

        // POST: SurveyQuestions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuestionId,SurveyId,OrderId")] SurveyQuestion surveyQuestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surveyQuestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", surveyQuestion.QuestionId);
            ViewData["SurveyId"] = new SelectList(_context.Set<Survey>(), "Id", "Id", surveyQuestion.SurveyId);
            return View(surveyQuestion);
        }

        // GET: SurveyQuestions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyQuestion = await _context.SurveyQuestion.FindAsync(id);
            if (surveyQuestion == null)
            {
                return NotFound();
            }
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", surveyQuestion.QuestionId);
            ViewData["SurveyId"] = new SelectList(_context.Set<Survey>(), "Id", "Id", surveyQuestion.SurveyId);
            return View(surveyQuestion);
        }

        // POST: SurveyQuestions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuestionId,SurveyId,OrderId")] SurveyQuestion surveyQuestion)
        {
            if (id != surveyQuestion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surveyQuestion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurveyQuestionExists(surveyQuestion.Id))
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
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", surveyQuestion.QuestionId);
            ViewData["SurveyId"] = new SelectList(_context.Set<Survey>(), "Id", "Id", surveyQuestion.SurveyId);
            return View(surveyQuestion);
        }

        // GET: SurveyQuestions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyQuestion = await _context.SurveyQuestion
                .Include(s => s.Question)
                .Include(s => s.Survey)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surveyQuestion == null)
            {
                return NotFound();
            }

            return View(surveyQuestion);
        }

        // POST: SurveyQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surveyQuestion = await _context.SurveyQuestion.FindAsync(id);
            _context.SurveyQuestion.Remove(surveyQuestion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurveyQuestionExists(int id)
        {
            return _context.SurveyQuestion.Any(e => e.Id == id);
        }
    }
}
