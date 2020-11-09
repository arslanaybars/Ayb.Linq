using System.Collections.Generic;

namespace Ayb.Linq.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public virtual ICollection<Variant> Variants { get; set; }
    }
}
