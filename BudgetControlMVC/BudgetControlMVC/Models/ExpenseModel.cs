using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetControlMVC.Models
{
    public class ExpenseModel : EntityModel
    {
        [Key]
        public Guid expenseId { get; set; } = Guid.Empty;

        [Display(Name = "Amount")]
        public decimal expenseAmount { get; set; } = 0.0m;

        [Display(Name = "PreviousBalance")]
        public decimal previousBalance { get; set; } = 0.0m;

        

        public Guid CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual CategoryModel Category { get; set; }

    }
}
