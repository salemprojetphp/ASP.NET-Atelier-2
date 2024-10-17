using Microsoft.AspNetCore.Mvc;
using MyFrstMVCApp.Models;

namespace MyApp.Namespace
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {
            return View(GetAllClients());
        }

        private List<Client> GetAllClients()
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

    }
}
