using MediatR;

namespace OnionAPI.Application.Features.Products.Command.Queries.GetAllProducts
{
    public class GetAllProductQueryRequest : IRequest<IList<GetAllProductQueryResponse>>
    {
    }
}