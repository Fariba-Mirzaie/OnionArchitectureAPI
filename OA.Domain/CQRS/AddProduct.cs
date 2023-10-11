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
    public class AddProduct
    {
        public class Command : IRequest<int>
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public int Stock { get; set; }
            public int Rate { get; set; }
            public DateTime CreateDate { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, int>
        {
            private readonly MyContext _context;
            public CommandHandler(MyContext myContext) => _context = myContext;

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
               var entity = new Product
                {
                    Id = request.Id,
                    CreateDate = request.CreateDate,
                    Rate = request.Rate,
                    Stock = request.Stock,
                    Title = request.Title
                };

                await _context.products.AddAsync(entity, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
