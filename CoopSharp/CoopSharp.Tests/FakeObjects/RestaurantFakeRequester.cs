using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoopSharp.Tests.FakeObjects
{
  public class RestaurantFakeRequester : IRequester 
  {
    public Task<string> Get(string resource, IDictionary<string, string> queryParameters = null)
    {
      throw new System.NotImplementedException();
    }
  }
}
