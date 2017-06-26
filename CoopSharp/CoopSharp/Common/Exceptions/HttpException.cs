using System;
using System.Net;

namespace CoopSharp.Common.Exceptions
{
  // from https://stackoverflow.com/a/35829637/5962841
  public class HttpException : Exception
  {
    public HttpException(int httpStatusCode)
    {
      StatusCode = httpStatusCode;
    }

    public HttpException(HttpStatusCode httpStatusCode)
    {
      StatusCode = (int)httpStatusCode;
    }

    public HttpException(int httpStatusCode, string message) : base(message)
    {
      StatusCode = httpStatusCode;
    }

    public HttpException(HttpStatusCode httpStatusCode, string message) : base(message)
    {
      StatusCode = (int)httpStatusCode;
    }

    public HttpException(int httpStatusCode, string message, Exception inner) : base(message, inner)
    {
      StatusCode = httpStatusCode;
    }

    public HttpException(HttpStatusCode httpStatusCode, string message, Exception inner) : base(message, inner)
    {
      StatusCode = (int)httpStatusCode;
    }

    public int StatusCode { get; }
  }
}