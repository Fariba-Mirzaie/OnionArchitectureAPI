using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Application.Services
{
    public interface IProductService //نمای ریپازیتوری
    {
        bool CreateProduct(Product product);
        Product GetProductById(int ProductId);
    }
}
