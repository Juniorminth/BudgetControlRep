using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetControlMVC.Models
{
    public class BudgetModel : EntityModel
    {
        public string budgetName { get; set; }
        public decimal originalBudget { get; set; }
        public decimal currentBudget { get; set; }
        public int remainingPercent { get; set; }
        [Key]
        public Guid budgetId { get; set; }

    }
}
