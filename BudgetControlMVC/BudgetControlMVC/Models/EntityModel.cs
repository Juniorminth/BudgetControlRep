using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetControlMVC.Models
{
    public class EntityModel
    {
        [Display(Name = "CreatedOn")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MD-dd}", ApplyFormatInEditMode = true)]

        public DateTime createdOn { get; set; }

        [Display(Name = "ModifiedOn")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MD-dd}", ApplyFormatInEditMode = true)]

        public DateTime modifiedOn { get; set; }

        public Guid Id { get; set; } = Guid.Empty;
    }
}
