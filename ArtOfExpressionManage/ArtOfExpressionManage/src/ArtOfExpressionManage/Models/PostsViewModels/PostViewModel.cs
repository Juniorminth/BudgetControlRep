using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArtOfExpressionManage.Models.PostsViewModels
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostContent { get; set; }

        public DateTime CreatedOn { get; set; }


        public static void Stam()
        {

        }
    }
}
