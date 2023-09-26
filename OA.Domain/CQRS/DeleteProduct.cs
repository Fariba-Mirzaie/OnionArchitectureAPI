//using MediatR;
using OA.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.CQRS
{
    public class DeleteProduct
    {
        //public class Command : IRequest
        //{
        //    public int Id { get; set; }
        //}

        //public class CommandHandler : IRequestHandler<Command, Unit>
        //{
        //    private readonly MyContext _context;
        //    public CommandHandler(MyContext myContext) => _context = myContext;
        //    public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        //    {
        //        var product = await _context.products.FindAsync(request.Id);
        //        if (product == null) return Unit.Value;

        //         _context.products.Remove(product); //چرا await نذاشت
        //        await _context.SaveChangesAsync(cancellationToken);

        //        return Unit.Value;
        //    }
        //}
    }
}
