using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.DTO
{
    public class SoldProductsDTO
    {
        public int Count { get; set; }

        public ProductDetailsDTO[] Products { get; set; }
    }
}
