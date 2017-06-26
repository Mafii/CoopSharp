using System.Threading.Tasks;
using RestSharp;

namespace CoopSharp.Common
{
  public static class RestClientExtensions
  {
    public static async Task<RestResponse> ExecuteAsync(this RestClient client, RestRequest request)
    {
      var taskCompletion = new TaskCompletionSource<IRestResponse>();
      client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

      return (RestResponse) await taskCompletion.Task;
    }
  }
}