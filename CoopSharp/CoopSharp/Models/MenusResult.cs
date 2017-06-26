using System.Collections.Generic;

namespace CoopSharp.Models
{
  public class MenusResult
  {
    public MenusResult(IList<Menu> results)
    {
      Results = results;
    }

    public IList<Menu> Results { get; }
  }
}