namespace DocumentAPI.GraphApi.Application.Reviews.Queries.GetReviewById;

using Common.Enums;
using Common.Exceptions;
using Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class GetReviewByIdHandler : IRequestHandler<GetReviewByIdQuery, Review>
{
    private readonly IReviewsRepository repository;

    public GetReviewByIdHandler(IReviewsRepository repository)
    {
        this.repository = repository;
    }

    public async Task<Review> Handle(GetReviewByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await this.repository.GetReviewById(request.Id, cancellationToken);

        NotFoundException.ThrowIfNull(result, EntityType.Review);

        return result;
    }
}
