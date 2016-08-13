using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetControlMVC.Models
{
    public class AccountModel : EntityModel
    {
        [Key]
        public Guid accountId { get; set; } = Guid.Empty;
        public string accountName { get; set; }

        public Guid OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual SystemUser Owner { get; set; }


        public virtual ICollection<SystemUser> Contacts { get; set; } = new HashSet<SystemUser>();
    }
}