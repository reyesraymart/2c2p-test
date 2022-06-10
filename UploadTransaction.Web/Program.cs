using UploadTransaction.Core.Startup;
using UploadTransaction.DataLayer.Startup;
using UploadTransaction.Web.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json");
builder.Services.AddSwaggerGen();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllersWithViews(options =>
{
	options.Filters.Add(typeof(ExceptionFilter));
	options.Filters.Add(typeof(ValidateModelStateFilter));
	
});

builder.Services.AddDataLayer(builder.Configuration);
builder.Services.AddCore();

builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();