namespace BookifyDomain.Apartments;

public record Adress(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);