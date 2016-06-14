using System.Collections.Generic;

namespace CAP.UnitTestingAndTDD._6_IntegrationTests.Api
{
    public interface IFlickrClient
    {
        IEnumerable<ApiPhoto> Search(string searchTerm);
    }
}