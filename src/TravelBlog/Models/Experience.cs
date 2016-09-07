using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBlog.Models;

namespace TravelBlogPost.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string BlogPost { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
