using System;
using System.Collections.Generic;
using System.Text;

namespace EntityOneToMany
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string AlternativeText { get; set; }
        public Product Product { get; set; }
    }
}
