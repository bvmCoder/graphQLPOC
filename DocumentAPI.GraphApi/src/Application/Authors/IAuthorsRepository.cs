namespace DocumentAPI.GraphApi.Application.Authors;

using Entities;
using System.Threading.Tasks;

public interface IAuthorsRepository
{
    Task<List<Author>> GetAuthors(CancellationToken cancellationToken);
    Task<Author> GetAuthorById(Guid id, CancellationToken cancellationToken);
    Task<bool> AuthorExists(Guid id, CancellationToken cancellationToken);
}
