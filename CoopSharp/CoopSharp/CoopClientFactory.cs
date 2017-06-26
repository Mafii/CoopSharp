namespace CoopSharp
{
  public class CoopClientFactory : ICoopClientFactory
  {
    public ICoopClient Create(IRequester requester = null)
    {
      return new CoopClient(requester ?? new Requester());
    }
  }
}