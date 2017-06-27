using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoopSharp.Tests.FakeObjects
{
  public class RestaurantFakeRequester : IRequester
  {
    public async Task<string> Get(string resource, IDictionary<string, string> queryParameters = null)
    {
      throw new System.NotImplementedException();

      // if (queryParameters.Count != 1 || queryParameters.Keys.Single() != "")

      if (queryParameters.Count != 0 || resource != "/locations")
      {
        throw new NotSupportedException();
      }

      return RESULT;
    }

    private const string RESULT = @"{
  ""results"": [
    {
      ""id"": 2257, 
      ""location"": {
        ""address"": {
          ""city"": ""Kriens"", 
          ""house_number"": ""2"", 
          ""street"": ""Hobacherweg"", 
          ""zip"": 6010
        }, 
        ""coordinates"": [
          8.273273, 
          47.0344
        ]
      }, 
      ""name"": ""Kriens Schappe Bistro""
    }, 
    {
      ""id"": 2135, 
      ""location"": {
        ""address"": {
          ""city"": ""Emmenbr\u00fccke"", 
          ""house_number"": ""1"", 
          ""street"": ""Fichtenstrasse"", 
          ""zip"": 6020
        }, 
        ""coordinates"": [
          8.290494, 
          47.073261
        ]
      }, 
      ""name"": ""Emmenbr\u00fccke""
    }, 
    {
      ""id"": 2847, 
      ""location"": {
        ""address"": {
          ""city"": ""Kriens"", 
          ""house_number"": ""19"", 
          ""street"": ""Ringstrasse"", 
          ""zip"": 6010
        }, 
        ""coordinates"": [
          8.295953, 
          47.020227
        ]
      }, 
      ""name"": ""Kriens Pilatusmarkt""
    }, 
    {
      ""id"": 2130, 
      ""location"": {
        ""address"": {
          ""city"": ""Luzern"", 
          ""house_number"": ""9"", 
          ""street"": ""Z\u00fcrichstrasse"", 
          ""zip"": 6004
        }, 
        ""coordinates"": [
          8.310045, 
          47.056913
        ]
      }, 
      ""name"": ""L\u00f6wencenter LU""
    }, 
    {
      ""id"": 2575, 
      ""location"": {
        ""address"": {
          ""city"": ""Schenkon"", 
          ""house_number"": """", 
          ""street"": ""Zellfeld"", 
          ""zip"": 6214
        }, 
        ""coordinates"": [
          8.126401, 
          47.178165
        ]
      }, 
      ""name"": ""Schenkon""
    }, 
    {
      ""id"": 2131, 
      ""location"": {
        ""address"": {
          ""city"": ""Stans"", 
          ""house_number"": ""4/6"", 
          ""street"": ""Buochserstrasse"", 
          ""zip"": 6370
        }, 
        ""coordinates"": [
          8.368674, 
          46.958373
        ]
      }, 
      ""name"": ""Stans""
    }, 
    {
      ""id"": 2138, 
      ""location"": {
        ""address"": {
          ""city"": ""Sarnen"", 
          ""house_number"": ""32"", 
          ""street"": ""Marktstrasse"", 
          ""zip"": 6060
        }, 
        ""coordinates"": [
          8.251211, 
          46.897303
        ]
      }, 
      ""name"": ""Sarnen""
    }, 
    {
      ""id"": 2258, 
      ""location"": {
        ""address"": {
          ""city"": ""Willisau"", 
          ""house_number"": """", 
          ""street"": ""Feldli"", 
          ""zip"": 6130
        }, 
        ""coordinates"": [
          7.997246, 
          47.127368
        ]
      }, 
      ""name"": ""Willisau""
    }, 
    {
      ""id"": 2038, 
      ""location"": {
        ""address"": {
          ""city"": ""Reinach"", 
          ""house_number"": ""134"", 
          ""street"": ""Obere Stumpenbachstrasse"", 
          ""zip"": 5734
        }, 
        ""coordinates"": [
          8.182447, 
          47.25163
        ]
      }, 
      ""name"": ""Reinach AG""
    }, 
    {
      ""id"": 2136, 
      ""location"": {
        ""address"": {
          ""city"": ""Zug"", 
          ""house_number"": ""6"", 
          ""street"": ""Baarerstrasse"", 
          ""zip"": 6300
        }, 
        ""coordinates"": [
          8.516536, 
          47.171017
        ]
      }, 
      ""name"": ""Zug Neustadt""
    }, 
    {
      ""id"": 2317, 
      ""location"": {
        ""address"": {
          ""city"": ""Baar"", 
          ""house_number"": ""3"", 
          ""street"": ""Poststrasse"", 
          ""zip"": 6340
        }, 
        ""coordinates"": [
          8.524314, 
          47.194854
        ]
      }, 
      ""name"": ""Baar Gotthard""
    }, 
    {
      ""id"": 2133, 
      ""location"": {
        ""address"": {
          ""city"": ""Baar"", 
          ""house_number"": ""10"", 
          ""street"": ""L\u00e4ttichstrasse"", 
          ""zip"": 6340
        }, 
        ""coordinates"": [
          8.540937, 
          47.201623
        ]
      }, 
      ""name"": ""Baar Delfin""
    }, 
    {
      ""id"": 2137, 
      ""location"": {
        ""address"": {
          ""city"": ""Engelberg"", 
          ""house_number"": ""5"", 
          ""street"": ""Titliszentrum"", 
          ""zip"": 6390
        }, 
        ""coordinates"": [
          8.404397, 
          46.820871
        ]
      }, 
      ""name"": ""Engelberg""
    }, 
    {
      ""id"": 2090, 
      ""location"": {
        ""address"": {
          ""city"": ""Affoltern am Albis"", 
          ""house_number"": ""15"", 
          ""street"": ""B\u00fcelstrasse"", 
          ""zip"": 8910
        }, 
        ""coordinates"": [
          8.446388, 
          47.274164
        ]
      }, 
      ""name"": ""Affoltern am Albis""
    }, 
    {
      ""id"": 2461, 
      ""location"": {
        ""address"": {
          ""city"": ""Seewen"", 
          ""house_number"": """", 
          ""street"": ""Steinbislin 7"", 
          ""zip"": 6423
        }, 
        ""coordinates"": [
          8.628244, 
          47.033456
        ]
      }, 
      ""name"": ""Seewen Markt""
    }
  ]
}
";
  }
}
