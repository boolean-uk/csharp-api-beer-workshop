using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Repository;

namespace workshop.wwwapi.Endpoints
{
    public static class StudentEndpoint
    {
        public static void ConfigureStudentEndpoints(this WebApplication app)
        {
            var studnets = app.MapGroup("students");

            studnets.MapGet("/", GetStudents);
        
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetStudents(IStudentRepository repository)
        {

            var results = await repository.GetStudents();
            return TypedResults.Ok(results);
        }
    }
}
