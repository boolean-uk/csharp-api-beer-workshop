using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Repository;

namespace workshop.wwwapi.Endpoints
{
    public static class BeerEndpoint
    {
        public static void ConfigureBeerEndpoints(this WebApplication app)
        {
            var bottles = app.MapGroup("bottles");

            bottles.MapGet("/", GetBottles);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBottles(IRepository repository)
        {

            var results = repository.GetBottles();
            return TypedResults.Ok(results);
        }

    }
}
