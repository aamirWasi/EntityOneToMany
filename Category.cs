using System;
using System.Collections.Generic;
using System.Text;

namespace EntityOneToMany
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> Categories { get; set; }
    }
}
