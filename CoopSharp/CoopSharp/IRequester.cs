using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoopSharp
{
  /// <summary>
  /// Sends requests to the api and returns the retrieved results.
  /// </summary>
  public interface IRequester
  {
    Task<string> Get(string resource, IDictionary<string, string> queryParameters = null);
  }
}