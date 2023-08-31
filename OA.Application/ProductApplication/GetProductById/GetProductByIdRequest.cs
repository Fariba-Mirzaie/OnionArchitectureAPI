using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Application.ProductApplication.GetProductById
{
    public class GetProductByIdRequest : IRequest<bool> //product
    {
        public string ProductId { get; set; }

    }
}
