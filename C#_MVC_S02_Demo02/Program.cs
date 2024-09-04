namespace C__MVC_S02_Demo02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //To Add Any Services Should be before build
            //builder.Services.AddControllers();//To Registers Web APIS Services
            //builder.Services.AddControllersWithViews();//To Registers MVC Services
            //builder.Services.AddRazorPages();//To Registers Razors Pages Services
            builder.Services.AddMvc();//To Registers all web [MVC,APIS,Razor Pages]  Services
            var app = builder.Build();
            //Routing
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/hamada", () => "Hello Hamada!");


            //To Make Routing Based ON Controller  (Movies)
            app.MapControllerRoute
                (
                name: "Default",
                //pattern: "/controller/action/id"//static
               pattern: "/{controller}/{action}/{id}"//static
               //pattern: "/{controller=Movies}/{action=GetMovies}/{id=1}"//Constraint 
               // pattern: "/{controller=Movies}/{action=GetMovies}/{id:int?}"//Constraint 
                );

            app.Run();
        }
    }
}
