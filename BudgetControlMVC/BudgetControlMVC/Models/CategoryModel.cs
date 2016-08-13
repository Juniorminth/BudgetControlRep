using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BudgetControlMVC.Models
{
    public class CategoryModel  : EntityModel
    {
        [Key]
        public Guid categoryId { get; set; } = Guid.Empty;
        [Display(Name ="Name")]
        public string categoryName { get; set; }
        [Display(Name = "Rank")]
        public int rank { get; set; } = 1;

        public virtual ICollection<ExpenseModel> Expenses { get; set; } = new HashSet<ExpenseModel>();
    }

    
}