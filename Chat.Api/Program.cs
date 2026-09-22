using Chat.DataAccess;

namespace Chat.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDataAccess(builder.Configuration);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();


            app.UseHttpsRedirection();


            app.MapControllers();

            app.Run();
        }
    }
}
