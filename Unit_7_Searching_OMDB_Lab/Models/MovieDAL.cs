using RestSharp;

namespace Unit_7_Searching_OMDB_Lab.Models
{
    public class MovieDAL
    {
        public Movie GetMovieByTitle(string title)
        {
            string URL = $"http://www.omdbapi.com/?t={title}&apikey=131c98cf";
            RestClient client = new RestClient(URL);
            RestRequest request = new RestRequest();
            Movie response = client.Get<Movie>(request);
            return response;
        }

        public List<Movie> GetThreeMovies(string title1, string title2, string title3)
        {
            string URL1 = $"http://www.omdbapi.com/?t={title1}&apikey=131c98cf";
            RestClient client1 = new RestClient(URL1);
            RestRequest request1 = new RestRequest();
            Task<Movie> response1 = client1.GetAsync<Movie>(request1);
            Movie movie1 = response1.Result;

            string URL2 = $"http://www.omdbapi.com/?t={title2}&apikey=131c98cf";
            RestClient client2 = new RestClient(URL2);
            RestRequest request2 = new RestRequest();
            Task<Movie> response2 = client2.GetAsync<Movie>(request2);
            Movie movie2 = response2.Result;

            string URL3 = $"http://www.omdbapi.com/?t={title3}&apikey=131c98cf";
            RestClient client3 = new RestClient(URL3);
            RestRequest request3 = new RestRequest();
            Task<Movie> response3 = client3.GetAsync<Movie>(request3);
            Movie movie3 = response3.Result;

            List<Movie> result = new List<Movie>() { movie1, movie2, movie3};
            return result;
        }
    }
}
