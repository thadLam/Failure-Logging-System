var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

/*// Add services to the container.
builder.Services.AddControllersWithViews();*/


var app = builder.Build();

// Configure the HTTP request pipeline.
startup.Configure(app, app.Environment);

app.Run();
