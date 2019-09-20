using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityOneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ShoppingContext();
            //ProductDemo(context);
            ProductCategoryDemo(context);
        }

        private static void ProductCategoryDemo(ShoppingContext context)
        {
            //context.Categories.Add(new Category
            //{
            //    Name = "Electronics"
            //});
            //context.Categories.Add(new Category
            //{
            //    Name = "Books"
            //});
            //context.Categories.Add(new Category
            //{
            //    Name = "Cloth"
            //});
            //context.SaveChanges();
            //var categoryItem = context.Categories.Where(x => x.Name == "Electronics").FirstOrDefault();
            //context.Products.Add(new Product
            //{
            //    Name = "Camera",
            //    Price = 345,
            //    Images = new List<ProductImage>
            //    {
            //        new ProductImage
            //        {
            //            AlternativeText="Camera Image",
            //            Url="http://mysite.com/images/camera.png"
            //        },
            //        new ProductImage
            //        {
            //            AlternativeText="Camera Image 2",
            //            Url="http://mysite.com/images/camera2.png"
            //        }
            //    },
            //    Categories = new List<ProductCategory>
            //    {
            //        new ProductCategory
            //        {
            //            Category=categoryItem
            //        }
            //    }
            //});
            //context.SaveChanges();
            var productItem = context.Products.Where(x => x.Id == 2)
                .Include(nameof(Product.Categories))
                .Include(nameof(Product.Images))
                .FirstOrDefault();
            foreach (var img in productItem.Images)
            {
                context.ProductImages.Remove(img);
            }
            context.Products.Remove(productItem);
            context.SaveChanges();
        }

        private static void ProductDemo(ShoppingContext context)
        {
            //context.Products.Add(new Product
            //{
            //    Name = "Camera",
            //    Price = 300,
            //    Images = new List<ProductImage>
            //    {
            //         new ProductImage
            //         {
            //             AlternativeText="Camera Image",
            //             Url="http://mysite.com/images/camera.jpg"
            //         },
            //         new ProductImage
            //         {
            //             AlternativeText="Camera Image 2",
            //             Url="http://mysite.com/images/camera.jpg2"
            //         }
            //    }
            //});
            //context.SaveChanges();

            /*Data Update

            var product = context.Products.Where(x => x.Id == 1)
                .Include(nameof(Product.Images))
                .FirstOrDefault();
            Console.WriteLine($"{product.Name}\n{product.Price}\n{product.Id}");
            product.Price = 350;
            context.SaveChanges();

            Data Update */



            /*Data delete
             
            foreach (var image in product.Images)
            {
                context.ProductImages.Remove(image);
            }
            context.Products.Remove(product);
            context.SaveChanges();

             Data delete*/
        }
    }
}
