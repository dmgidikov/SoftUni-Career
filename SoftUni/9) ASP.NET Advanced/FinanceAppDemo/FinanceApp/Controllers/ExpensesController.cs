namespace FinanceApp.Controllers
{
    using Data;
    using Models;
    using Data.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class ExpensesController : Controller
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        public async Task<IActionResult> Index()
        {
            var expenses = await _expensesService.GetAllExpensesAsync();
            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expensesService.AddExpense(expense);
                return RedirectToAction(nameof(Index));
            }
            return View(expense);
        }

        public IActionResult GetChart()
        {   
            var data = _expensesService.GetChartData();
            return Json(data);
        }
    }
}