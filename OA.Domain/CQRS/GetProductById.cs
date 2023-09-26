using MediatR;
using OA.Domain.Context;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.CQRS
{
    public class GetProductById
    {
        public class Query : IRequest<Product>
        {
            public int ProductId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, Product>
        {
            private readonly MyContext _context;
            public QueryHandler(MyContext myContext) => _context = myContext;

            public async Task<Product> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.products.FindAsync(request.ProductId);

            }
        }

    }
}
