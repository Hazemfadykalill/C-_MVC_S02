using Microsoft.AspNetCore.Mvc;

namespace C__MVC_S02_Demo02.Controllers
{
    public class MoviesController:Controller
    {

        //Action
        public string GetMovies(int Id)
        {
            return $"Id Is : {Id}";
        }
    }
}
