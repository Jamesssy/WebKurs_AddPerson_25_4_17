using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebKurs_AddPerson_25_4_17.Model
{
    public class SimplePerson
    {
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Name { get; set; }

        [Range(0, 120)]
        [Required]
        public int Age { get; set; }
    }

    public class PersonDBContext : DbContext
    {
        public DbSet<SimplePerson> Person { get; set; }
    }
}
