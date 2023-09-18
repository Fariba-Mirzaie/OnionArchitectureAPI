using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Application.Functions
{
    public static class AddProductTitle
    {
        public static string AddTitle(Product product)
        {
            return product.Title + "_newone";
        }
    }
}
