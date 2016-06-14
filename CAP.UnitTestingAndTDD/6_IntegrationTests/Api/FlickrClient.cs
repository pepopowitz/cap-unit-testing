using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Extensions.MonoHttp;

namespace CAP.UnitTestingAndTDD._6_IntegrationTests.Api
{
    public class FlickrClient : IFlickrClient
    {
        public IEnumerable<ApiPhoto> Search(string searchTerm)
        {
            var apiKey = ConfigurationManager.AppSettings["flickrApi:Key"];

            var client = new RestClient();
            client.BaseUrl = new Uri("https://api.flickr.com/");

            var requestUrl = string.Format(
                "/services/rest/?method=flickr.photos.search&nojsoncallback=1&api_key={0}&text={1}&per_page=10&format=json",
                apiKey,
                HttpUtility.UrlEncode(searchTerm));
            var request = new RestRequest(requestUrl);

            var result = client.Get<ApiSearchResult>(request);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                if (result.Data != null)
                {
                    return result.Data?.Photos?.Photo;
                }
            }

            return Enumerable.Empty<ApiPhoto>();

        }
    }
}
