namespace DocumentAPI.GraphApi.Application.Movies;

using Entities;
using System.Threading.Tasks;

public interface IMoviesRepository
{
    Task<List<Movie>> GetMovies(CancellationToken cancellationToken);
    Task<Movie> GetMovieById(Guid id, CancellationToken cancellationToken);
    Task<bool> MovieExists(Guid id, CancellationToken cancellationToken);
}
