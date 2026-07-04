using EmployeeDependencyInjectionApi.Models;

namespace EmployeeDependencyInjectionApi.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
        IQueryable GetChartData();
    }
}