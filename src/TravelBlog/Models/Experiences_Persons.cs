using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelBlogPost.Models;

namespace TravelBlog.Models
{
    public class Experiences_Persons
    {
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
