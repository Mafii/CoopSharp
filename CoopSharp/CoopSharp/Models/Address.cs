using System.Diagnostics;

namespace CoopSharp.Models
{
  /// <summary>
  /// An address representing a swiss city
  /// </summary>
  public class Address
  {
    public Address(string city, string houseNumber, string street, int postalCode)
    {
      City = city;
      HouseNumber = houseNumber;
      Street = street;
      PostalCode = postalCode;
    }

    public string City { get; }

    /// <summary>
    /// The house number in the Address (e.g.: 22, 25a, 193c).
    /// </summary>
    public string HouseNumber { get; }

    public string Street { get; }

    /// <summary>
    /// Normally a 4 digit long postal code of Switzerland
    /// </summary>
    public int PostalCode { get; }
  }
}