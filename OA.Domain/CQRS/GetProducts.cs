using MediatR;
using Microsoft.EntityFrameworkCore;
using OA.Domain.Context;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.CQRS
{
    public class GetProducts
    {
        public class Query : IRequest<IEnumerable<Product>>
        { }


        public class QueryHandler : IRequestHandler<Query, IEnumerable<Product>> //ریسپانس/ریگوئیست
        {
            private readonly MyContext _myContext;
            public async Task<IEnumerable<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _myContext.products.ToListAsync();
            }
        }

    }
}
