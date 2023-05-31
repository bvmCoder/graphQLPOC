namespace DocumentAPI.GraphApi.Application.Authors.Queries.GetAuthorById;

using Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

public class GetAuthorByIdQuery : IRequest<Author>
{
    [Required]
    public Guid Id { get; init; }
}
