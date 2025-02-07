using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddRazorPages()
	.AddRazorPagesOptions(options =>
	{
		options.Conventions.AddPageRoute("/AllCows", "AllCows/Gallery/{id1}/Page{id2}");
		options.Conventions.AddPageRoute("/AllCows", "AllCows/Gallery/{id1}/{id2}");
		options.Conventions.AddPageRoute("/AllCows", "AllCows/Gallery/{id1}");
		options.Conventions.AddPageRoute("/index", "{*url}");
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