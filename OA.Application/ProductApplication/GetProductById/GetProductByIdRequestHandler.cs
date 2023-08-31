using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OA.Application.ProductApplication.GetProductById
{
    public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, bool> //product
    {
        private readonly IProductRepository _repository;
        public GetProductByIdRequestHandler(IProductRepository productRepository)
        {
            _repository = productRepository;    

        }
        public Task<bool> Handle(GetProductByIdRequest request, CancellationToken cancellationToken) //product
        {
            return Task.FromResult(_repository.GetBookById(request.ProductId));
        }
    }
}
