﻿using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.Repository
{
    public interface IProductRepository
    {
        bool CreateProduct(Product product);
        Product GetProductById(int productId);
        void SaveChange();
    }
}
