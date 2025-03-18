using System.Text.Json.Serialization;
using Bogus;
using TheSampleApi.Models;
using TheSampleApi.Models.Enums;

namespace TheSampleApi.Data.FakeData;

public sealed class PersonFakeModel : Faker<PersonModel>
{
    public PersonFakeModel(): base("fa")
    {
        Randomizer.Seed = new Random(123);
        RuleFor(x => x.Id, f => f.Random.Int(1, 100));
        RuleFor(x => x.FirstName, f => f.Person.FirstName);
        RuleFor(x => x.LastName, f => f.Person.LastName);
        RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumber("09## #### ###"));
        RuleFor(x => x.Age, f => f.Random.Number(18, 60));
        RuleFor(x => x.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName));
        RuleFor(x => x.Rating, f => f.PickRandom<CreditRating>());
    }
}