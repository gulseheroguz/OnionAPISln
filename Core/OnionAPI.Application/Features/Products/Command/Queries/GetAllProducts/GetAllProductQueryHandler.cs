using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionAPI.Application.DTOs;
using OnionAPI.Application.Interfaces.AutoMapper;
using OnionAPI.Application.Interfaces.IUnitOfWorks;
using OnionAPI.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Products.Command.Queries.GetAllProducts
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, IList<GetAllProductQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x => x.Include(b => b.Brand));

            var brand = _mapper.Map<BrandDto, Brand>(new Brand());

            var map =_mapper.Map<GetAllProductQueryResponse, Product>(products);

            foreach (var product in map)
                product.Price -= (product.Price * product.Discount / 100);

            return map;

            //List<GetAllProductQueryResponse> response = new();

            //foreach (var product in products)
            //    response.Add(new GetAllProductQueryResponse

            //    {
            //        Title = product.Title,
            //        Description = product.Description,
            //        Discount = product.Discount,
            //        Price = product.Price - (product.Price * product.Discount / 100)

            //    });
            //return response;
        }
    }
}


