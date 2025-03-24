using CodingInterview3.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CodingInterview3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddHttpClient();

            var app = builder.Build();

            var controller = new CharacterController();

            app.MapGet("/", ([FromServices] HttpClient httpClient) => controller.RetrieveAll(httpClient));

            app.Run();
        }
    }
}
