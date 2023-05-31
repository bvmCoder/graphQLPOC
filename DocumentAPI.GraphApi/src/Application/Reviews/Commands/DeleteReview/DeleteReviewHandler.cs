namespace DocumentAPI.GraphApi.Application.Reviews.Commands.DeleteReview;

using Common.Enums;
using Common.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class DeleteReviewHandler : IRequestHandler<DeleteReviewCommand, bool>
{
    private readonly IReviewsRepository repository;

    public DeleteReviewHandler(IReviewsRepository repository)
    {
        this.repository = repository;
    }

    public async Task<bool> Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
    {
        if (!await this.repository.ReviewExists(request.Id, cancellationToken))
        {
            NotFoundException.Throw(EntityType.Review);
        }

        return await this.repository.DeleteReview(request.Id, cancellationToken);
    }
}
