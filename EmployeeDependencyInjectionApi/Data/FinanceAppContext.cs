using EmployeeDependencyInjectionApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDependencyInjectionApi.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses
        {
            get; set;
        }
    }
}
