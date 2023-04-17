using Microsoft.Extensions.Configuration;
using System;

namespace Smartproduct.Web.Utils
{
    public static class UriHelper
    {
        private static string GetUrl()
        {
            var config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
              .Build();
            return config.GetSection("WebApiUrl").GetSection("v1").Value;
        }

        public static class Api
        {
            public static Uri FruitSaApi => new Uri($"{GetUrl()}");
        }

        public static class Controller
        {
            public const string User = "User/";
            public const string Category = "Category/";
            public const string File = "File/";
        }
    }
}
