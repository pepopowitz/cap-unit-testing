using System.Collections.Generic;

namespace CAP.UnitTestingAndTDD._6_IntegrationTests.Api
{
    public class ApiPhotoCollection
    {
        public int Page { get; set; }
        public string Total { get; set; }
        public List<ApiPhoto> Photo { get; set; } 
    }
}