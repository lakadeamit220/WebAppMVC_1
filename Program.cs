using WebAppMVC_1.Repositories;

namespace WebAppMVC_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

            //var app = WebApplication.CreateBuilder(args).Build();

            //app.MapGet("/items", () => "Fetching items...");
            //app.MapPost("/items", () => "Creating an item...");
            //app.MapPut("/items/{id}", (int id) => $"Updating item {id}...");
            //app.MapDelete("/items/{id}", (int id) => $"Deleting item {id}...");

            //app.Use(async (context, next) =>
            //{
            //    var method = context.Request.Method; // Access HTTP method
            //    var path = context.Request.Path;     // Access requested path
            //    await context.Response.WriteAsync($"Request: {method} {path}");
            //    await next(); // Call the next middleware
            //});


            //app.Run();

        }
    }
}
