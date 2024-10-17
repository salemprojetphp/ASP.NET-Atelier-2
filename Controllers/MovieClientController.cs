using Microsoft.AspNetCore.Mvc;
using MyFrstMVCApp.Models;

namespace MyApp.Namespace
{
    public class MovieClientController : Controller
    {
        // GET: MovieClientController
        public ActionResult Index()
        {
            MovieClient movieClientView = new MovieClient()
            {
                Movies=getAllMovies(),
                Clients=getAllClients()
                
            };
            return View(movieClientView);
        }
        private List<Movie> getAllMovies(){
            return new List<Movie>{
                new Movie{Id=1, Title="The Godfather"},
                new Movie{Id=2, Title="The Dark Knight"},
                new Movie{Id=3, Title="Inception"},
                new Movie{Id=4, Title="The Matrix"},
                new Movie{Id=5, Title="Interstellar"},
                new Movie{Id=6, Title="The Lion King"},
            };

        }
        private List<Client> getAllClients()
        {
            return new List<Client>
            {
                new Client { Id = 1, Name = "John Doe" },
                new Client { Id = 2, Name = "Jane Doe" },
                new Client { Id = 3, Name = "Alice" },
                new Client { Id = 4, Name = "Bob" },
                new Client { Id = 5, Name = "Charlie" },
                new Client { Id = 6, Name = "David" },
            };
        }
        public ActionResult Details(int? id){
            if(id==null){
                return NotFound();
            }
            var c=getAllClients().SingleOrDefault(c=>c.Id==id);
            return View(c);
        }

    }
}
