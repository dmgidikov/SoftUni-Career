namespace FinanceApp.Data.Services
{
    using Models;

    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAllExpensesAsync();

        Task AddExpense(Expense expense);

        IQueryable GetChartData();
    }
}