using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.Entities
{
    public class Product :BaseEntity
    {
        public string Title { get; set; }
        public int Stock { get; set; }
        public int Rate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
