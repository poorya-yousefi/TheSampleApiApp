using TheSampleApi.Data.FakeData;
using TheSampleApi.Models;

namespace TheSampleApi.Data;

public class PersonData
{
    private const int PersonsSize = 10;
    
    public PersonData()
    {
        var faker = new PersonFakeModel();
        PersonsList = faker.GenerateLazy(PersonsSize).ToList();
    }

    public IEnumerable<PersonModel> PersonsList { get; }
}