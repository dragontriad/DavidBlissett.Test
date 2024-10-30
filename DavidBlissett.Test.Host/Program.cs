using DavidBlissett.Test.App.Services;
using DavidBlissett.Test.Host.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddScoped<ICustomerDataService, CustomerDataService>();

string environment_url = builder.Configuration.GetValue<string>("APIURL");
builder.Services.AddHttpClient<ICustomerDataService, CustomerDataService>(client =>
{
    client.BaseAddress = new Uri(environment_url);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
