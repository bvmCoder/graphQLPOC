namespace DocumentAPI.GraphApi.Presentation.GraphQL;

using DocumentAPI.GraphApi.Presentation.GraphQL.Mutations;
using DocumentAPI.GraphApi.Presentation.GraphQL.Queries;
using global::GraphQL.Types;
using System;

public class MovieReviewSchema : Schema
{
    public MovieReviewSchema(MovieReviewQueries query, MovieReviewMutations mutation, IServiceProvider serviceProvider) : base(serviceProvider)
    {
        this.Query = query;
        this.Mutation = mutation;
    }
}
