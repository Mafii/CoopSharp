using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using CoopSharp.Common;
using CoopSharp.Common.Exceptions;
using RestSharp;

namespace CoopSharp
{
  internal class Requester : IRequester
  {
    private readonly RestClient instance = new RestClient(@"https://themachine.jeremystucki.com/coop/api/v2");

    public async Task<string> Get(string resource, IDictionary<string, string> queryParameters = null)
    {
      var request = new RestRequest(resource, Method.GET);
      queryParameters?.ForEach((key, value) => request.AddQueryParameter(key, value));

      IRestResponse response = await instance.ExecuteAsync(request);

      if (response.StatusCode != HttpStatusCode.OK)
      {
        throw response.ErrorException ?? new HttpException(response.StatusCode, response.StatusDescription);
      }

      return response.Content;
    }
  }
}