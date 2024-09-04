using Microsoft.AspNetCore.Mvc;

namespace C__MVC_S02_Demo02.Controllers
{
    public class MoviesController:Controller
    {

        //Action
        //public ContentResult GetMovies(int Id)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = $"Id Is ContentResult :: {Id}";
        //   return result;
        //}


        //public RedirectToActionResult Test(int Id)
        //{
        //    RedirectToActionResult result = new RedirectToActionResult(actionName:"GetMovies",controllerName:"Movies",new {id=Id});

        //    return result;
        //}

        //public RedirectResult Test01(int Id)
        //{
        //    RedirectResult result = new RedirectResult("https://www.facebook.com");

        //    return result;
        //}


        [HttpGet]
        [ActionName("GetMoviesById")]
        public IActionResult GetMovies(int Id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Id Is ContentResult :: {Id}";
            //return result;


            //Or 

            //Helper Method
            return Content($"Id Is ContentResult :: {Id}");

        }


        public IActionResult Test(int Id)
        {
            RedirectToActionResult result = new RedirectToActionResult(actionName: "GetMovies", controllerName: "Movies", new { id = Id });

            return result;
        }

        public IActionResult Test01(int Id)
        {
            RedirectResult result = new RedirectResult("https://www.facebook.com");

            return result;
        }
    }
}
