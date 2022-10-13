using bacit_dotnet.MVC.Models.Users;
using bacit_dotnet.MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace bacit_dotnet.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository userRepository;

        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Save(UserViewModel model)
        {

<<<<<<< HEAD
            UserEntity newUser = new UserEntity
            {
=======
         //userentity skal samsvare med en tabell i database
            UserEntity newUser = new UserEntity { 
>>>>>>> 3253d016b1351f525ae0a514e394a62fed68a5ba
                Name = model.Name,
                EmpNr = model.EmpNr,
                Password = model.Password,
                Team = model.Team,
                Admin = model.Admin
            };
            userRepository.Save(newUser);
            return View("Index");
        }
    }
}
