namespace DocumentAPI.GraphApi.Application.Reviews.Commands.UpdateReview;

using Common.Enums;
using Common.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class UpdateReviewHandler : IRequestHandler<UpdateReviewCommand, bool>
{
    private readonly IReviewsRepository repository;

    public UpdateReviewHandler(IReviewsRepository repository)
    {
        this.repository = repository;
    }

    public async Task<bool> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
    {
        if (!await this.repository.ReviewExists(request.Id, cancellationToken))
        {
            NotFoundException.Throw(EntityType.Review);
        }

        return await this.repository.UpdateReview(request.Id, request.AuthorId, request.MovieId, request.Stars, cancellationToken);
    }
}
