using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TravelBlogPost.Models;

namespace TravelBlog.Models
{
    [Table("Categories")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Destination { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
