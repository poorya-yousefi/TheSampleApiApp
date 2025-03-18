using System.Text.Json.Serialization;
using TheSampleApi.Models.Enums;

namespace TheSampleApi.Models;

public class PersonModel
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string PhoneNumber { get; set; }
    public int Age { get; set; }
    public required string Email { get; set; }
    public CreditRating Rating { get; set; }
}