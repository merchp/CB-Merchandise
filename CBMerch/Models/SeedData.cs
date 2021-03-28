using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CBMerch.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            CBMerchDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<CBMerchDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Merchant Prince Emblem Hoodie",
                        Description = " A hoodie with the MP Emblem big and flashy on the front.",
                        Category = "Outerwear",
                        Price = 30
                    },

                     new Product
                     {
                         Name = "Merchant Prince Emblem Dad Cap",
                         Description = " A Dad Cap with the MP Emblem on the front.",
                         Category = "Hats",
                         Price = 30
                     },

                      new Product
                      {
                          Name = "Merchant Prince Emblem Tee",
                          Description = " A shirt with the MP Emblem big and flashy on the front.",
                          Category = "Shirts",
                          Price = 30
                      }
                      );
                context.SaveChanges();

            }
        }
    }

}
