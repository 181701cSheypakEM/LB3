using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sheypak_LB3.Models
{
    public static class StaticDB
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>()
        {
            new ProductModel()
            {
                Id = 1,
                Description = "Красный томат из Франции",
                Name = "Томат",
                Price = "85 USD"
            },
                new ProductModel()
            {
                Id = 2,
                Description = "Зеленый томат из Германии",
                Name = "Томат",
                Price = "25 USD"
            },
                new ProductModel()
            {
                Id = 3,
                Description = "Желтый томат из Беларуси",
                Name = "Томат",
                Price = "15 USD"
            }
        };
    }
}
