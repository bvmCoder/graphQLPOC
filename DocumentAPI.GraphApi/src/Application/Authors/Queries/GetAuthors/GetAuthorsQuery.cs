namespace DocumentAPI.GraphApi.Application.Authors.Queries.GetAuthors;

using Entities;
using MediatR;

public class GetAuthorsQuery : IRequest<List<Author>>
{
}
