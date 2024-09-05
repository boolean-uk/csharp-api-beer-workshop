using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.DTO;
using workshop.wwwapi.Models;
using workshop.wwwapi.Repository;
using workshop.wwwapi.ViewModels;

namespace workshop.wwwapi.Endpoints
{
    public static class BeerEndpoint
    {
        public static void ConfigureBeerEndpoints(this WebApplication app)
        {
            var bottles = app.MapGroup("bottles");

            bottles.MapGet("/", GetBottles);
            bottles.MapPost("/", AddABottle);
            bottles.MapPut("/{id}", UpdateABottle);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBottles(IBottleRepository repository)
        {
            //custom DTO
            GetBottlesResponse response = new GetBottlesResponse();

            var results = await repository.GetBottles();


            foreach(Bottle b in results)
            {
                DTOBottle bottle = new DTOBottle();
                bottle.Brand = b.Brand;

                DTOStudent student = new DTOStudent();
                student.Name = b.Owner.FirstName + " " + b.Owner.LastName;

                bottle.Owner = student;

                response.Bottles.Add(bottle);
                
            }


            return TypedResults.Ok(response);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddABottle(IBottleRepository repository, BottlePostModel model)
        {
            try
            {
                var result = await repository.AddBottle(new Bottle() { Brand = model.Brand, Size=model.Size, StudentId=model.StudentId});
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateABottle(IBottleRepository repository, int id, BottlePutModel model)
        {
            try
            {
                var target = await repository.GetById(id);
                target.Brand = model.Brand;           
                await repository.UpdateById(id, target);
                return TypedResults.Ok(target);
            }
            catch(Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

    }
}
