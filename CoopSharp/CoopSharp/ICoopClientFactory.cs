namespace CoopSharp
{
  public interface ICoopClientFactory
  {
    ICoopClient Create(IRequester requester = null);
  }
}