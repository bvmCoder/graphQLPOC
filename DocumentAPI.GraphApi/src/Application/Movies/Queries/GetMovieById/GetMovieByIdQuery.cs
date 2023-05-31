namespace DocumentAPI.GraphApi.Application.Movies.Queries.GetMovieById;

using Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

public class GetMovieByIdQuery : IRequest<Movie>
{
    [Required]
    public Guid Id { get; init; }
}
