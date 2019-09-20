using System;
using System.Collections.Generic;
using System.Text;

namespace EntityOneToMany
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IList<ProductImage> Images { get; set; }
        public List<ProductCategory> Categories { get; set; }
    }
}
