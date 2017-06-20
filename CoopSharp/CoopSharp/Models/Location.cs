namespace CoopSharp.Models
{
  public class Location
  {
    public Location(Coordinates coordinates, Address address)
    {
      Coordinates = coordinates;
      Address = address;
    }

    public Coordinates Coordinates { get; }

    public Address Address { get; }
  }
}