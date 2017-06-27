using System;

namespace CoopSharp.Common
{
  public static class DateExtensions
  {
    public static int ToUnixTimeStamp(this DateTime date)
      => (int)date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
  }
}
