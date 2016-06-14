using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP.UnitTestingAndTDD._6_IntegrationTests.Api;

namespace CAP.UnitTestingAndTDD._6_IntegrationTests
{
    public class FlickrReader
    {
        public FlickrReader(IFlickrClient flickrClient, IFlickrPhotoMapper flickrPhotoMapper)
        {
            _flickrClient = flickrClient;
            _flickrPhotoMapper = flickrPhotoMapper;
        }

        private IFlickrClient _flickrClient;
        private IFlickrPhotoMapper _flickrPhotoMapper;

        public IEnumerable<Photo> SearchFlickr(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentNullException("searchTerm");
            }

            var apiResults = _flickrClient.Search(searchTerm);

            if (apiResults != null)
            {
                return apiResults.Select(
                    api => _flickrPhotoMapper.Map(api));
            }

            return Enumerable.Empty<Photo>();
        } 
    }
}
