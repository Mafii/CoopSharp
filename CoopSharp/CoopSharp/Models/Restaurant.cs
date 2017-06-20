namespace CoopSharp.Models
{
  public class Restaurant
  {
    public Restaurant(int id, string name, Location location)
    {
      Id = id;
      Name = name;
      Location = location;
    }

    public int Id { get; }

    public string Name { get; }

    public Location Location { get; }
  }
}