using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BudgetControlMVC.Models
{
    public class BudgetDBContext : DbContext
    {
        public DbSet<CategoryModel> CategorySet { get; set; }
        public DbSet<ExpenseModel> ExpenseSet { get; set; }
        public DbSet<BudgetModel> BudgetSet { get; set; }
        public DbSet<SystemUser> SystemUserSet { get; set; }

        public DbSet<AccountModel> AccountSet { get; set; }
    }
}
