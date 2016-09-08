using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public List<Experiences_Persons> Experiences_Persons { get; set; }

    }
}
