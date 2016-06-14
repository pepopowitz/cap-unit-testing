namespace CAP.UnitTestingAndTDD._6_IntegrationTests
{
    public class FlickrPhotoMapper: IFlickrPhotoMapper
    {
        public Photo Map(ApiPhoto apiPhoto)
        {
            return new Photo()
            {
                Title = apiPhoto.Title,
                Url = string.Format("https://farm{0}.staticflickr.com/{1}/{2}_{3}.jpg",
                    apiPhoto.Farm,
                    apiPhoto.Server,
                    apiPhoto.Id,
                    apiPhoto.Secret)
            };
        }
    }
}