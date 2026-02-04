using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Core.Contract;
using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperTest.Helper;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services
    .AddSingleton<AccessControlList, AccessControlList>()
    .AddSingleton<ValidationHelper, ValidationHelper>()
    .AddSingleton<IGeoCaller, GeoCaller>()
    .AddSingleton<Geo, Geo>()
    .AddScoped<IGeoService, GeoService>();


if (!builder.Environment.IsDevelopment())
    builder.WebHost.ConfigureKestrel(options =>
    {
        // Ensure SSL is enabled and bind the HTTPS port.
        options.Listen(IPAddress.Any, 8080); // HTTP port (optional)

        // Configure HTTPS with a certificate located in the "Certificates" folder
        options.Listen(IPAddress.Any, 8081, listenOptions =>
        {
            var certificatePath = builder.Configuration["ASPNETCORE_Kestrel_Certificates_Default_Path"];
            var certificatePassword = builder.Configuration["ASPNETCORE_Kestrel_Certificates_Default_Password"];

            listenOptions.UseHttps(certificatePath, certificatePassword);
        });
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

SQLitePCL.Batteries.Init();

app.Run();
