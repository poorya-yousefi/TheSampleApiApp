
using TheSampleApi.Data;

namespace TheSampleApi.Endpoints;

public static class PersonEndpoints
{
    public static void AddPersonEndpoints(this WebApplication app)
    {
        app.MapGet("/persons", LoadAllPersons);
        app.MapGet("/persons/{id}", GetPerson);
    }

    private static IResult LoadAllPersons(PersonData personData, string? searchString)
    {
        var result = personData.PersonsList;
        if (string.IsNullOrWhiteSpace(searchString) == false)
        {
            result = result.Where(p => p.FirstName.Contains(searchString));
        }
        return Results.Ok(result);
    }
    
    private static IResult GetPerson(PersonData personData, int id)
    {
        var person = personData.PersonsList.FirstOrDefault(p => p.Id == id);
        if (person == null) return Results.NotFound();
        return Results.Ok(person);
    }
}