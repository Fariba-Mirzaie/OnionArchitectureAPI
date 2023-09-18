using OA.Application.Functions;
using OA.Domain.Entities;
using OA.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository repository)
        {
            _productRepository = repository;
        }
        public bool CreateProduct(Product product)
        {
            AddProductRate rate = new AddProductRate();
            try
            {
                if (product != null)
                {
                    product.Rate=  rate.AddRate(product.Rate);
                    _productRepository.CreateProduct(product);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Product GetProductById(int ProductId)
        {
            return _productRepository.GetProductById(ProductId);
        }
    }
}
