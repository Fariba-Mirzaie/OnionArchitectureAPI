using OA.Domain.Context;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContext _context;
        public ProductRepository(MyContext myContext)
        {
            _context = myContext;
        }

        public bool CreateProduct(Product product)
        {
            var newProduct = _context.products.Add(product);
            SaveChange();
            return true;
        }

        public Product GetProductById(int productId)
        {
            return _context.products.SingleOrDefault(p => p.Id == productId);
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
