namespace DocumentAPI.GraphApi.Presentation;

using DocumentAPI.GraphApi.Presentation.GraphQL;
using DocumentAPI.GraphApi.Presentation.GraphQL.Mutations;
using DocumentAPI.GraphApi.Presentation.GraphQL.Queries;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        _ = services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        _ = services.AddSingleton<MovieReviewQueries>();
        _ = services.AddSingleton<MovieReviewMutations>();
        _ = services.AddSingleton<MovieReviewSchema>();

        return services;
    }
}
