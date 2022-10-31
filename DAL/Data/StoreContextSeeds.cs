using DAL.Context;
using DAL.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class StoreContextSeeds
    {
        public static async Task InvokeSeeds(MyContext context,ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.types.Any())
                {
                    var tydata = File.ReadAllText("../DAL/Data/Seeds/types.json");
                    var indexs = JsonSerializer.Deserialize<List<BroductType>>(tydata);

                    for (var i = 0; i < indexs?.Count; i++)
                    {

                        context.types.Add(indexs[i]);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.brands.Any())
                {
                    var tydata = File.ReadAllText("../DAL/Data/Seeds/brands.json");
                    var indexs = JsonSerializer.Deserialize<List<ProductBrand>>(tydata);

                    for (var i = 0; i < indexs?.Count; i++)
                    {

                        context.brands.Add(indexs[i]);
                    }
                    await context.SaveChangesAsync();
                }
                if (!context.products.Any())
                {
                    var tydata = File.ReadAllText("../DAL/Data/Seeds/products.json");
                    var indexs = JsonSerializer.Deserialize<List<Product>>(tydata);

                    for (var i = 0; i < indexs?.Count; i++)
                    {

                        context.products.Add(indexs[i]);
                    }
                    await context.SaveChangesAsync();
                }

            }


            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeeds>();
                logger.LogError(ex.Message);
            }




        }
          
}
    }

