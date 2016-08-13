using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetControlMVC.Models
{
    public class SystemUser : EntityModel
    {
        public string Username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }

        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MD-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        [Key]
        public Guid userId { get; set; } = Guid.Empty;
        public Guid accountId { get; set; }
        [ForeignKey("accountId")]
        public virtual AccountModel account { get; set; }

    }
}
