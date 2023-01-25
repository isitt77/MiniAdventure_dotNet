using System.Net;
using Microsoft.EntityFrameworkCore;
using MiniAdventureDotNetWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseNpgsql(builder.Configuration
.GetConnectionString("AzureConnection")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.Use(async (context, next) =>
{
    await next();

    // not found error (404)
    if (context.Response.StatusCode == (int)HttpStatusCode.NotFound)
    {
        Console.WriteLine(context.Response.StatusCode);
        context.Request.Path = "/Home/Error";
        await next();
    }
    // // unhandled error (500)
    if (context.Response.StatusCode == (int)HttpStatusCode.InternalServerError)
    {
        Console.WriteLine(context.Response.StatusCode);
        context.Request.Path = "/Home/Error";
        await next();
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.Use(async (context, next) =>
{
    //CSP prevents cross scripting
    context.Response.Headers.Add("Content-Security-Policy",
        "default-src 'self'; connect-src 'self' wss:; script-src 'self';" +
        "style-src 'self'; img-src 'self'; child-src 'self';");
    await next();
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

