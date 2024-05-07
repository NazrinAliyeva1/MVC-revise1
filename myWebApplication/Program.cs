namespace myWebApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapGet("/", () => " World!");
            app.MapControllerRoute("default", "{controller=Home}/{action=Salam}/{id?}");
            app.Run();

        }
    }
}


