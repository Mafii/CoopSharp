using System;

namespace CoopSharp.Demo
{
  public static class OSVersionExtensions
  {
    public static bool IsWindows(this OperatingSystem operatingSystem)
    {
      return (int)operatingSystem.Platform < 4;
    }
  }
}