using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApi.Models
{
    public class Author : BaseEntity
    {
        public String Name { get; set; }
        public String Country { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public String UserName { get; set; }
        public String Password { get; set; }

    }
}
