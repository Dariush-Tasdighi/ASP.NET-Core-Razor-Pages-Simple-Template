using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var webApplicationOptions =
	new Microsoft.AspNetCore.Builder.WebApplicationOptions
	{
		EnvironmentName =
			Microsoft.Extensions.Hosting.Environments.Development,

		//EnvironmentName =
		//	Microsoft.Extensions.Hosting.Environments.Production,
	};

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(options: webApplicationOptions);

// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();

var app =
	builder.Build();

// IsDevelopment() -> using Microsoft.Extensions.Hosting;
if (app.Environment.IsDevelopment())
{
	// UseDeveloperExceptionPage() -> using Microsoft.AspNetCore.Builder;
	app.UseDeveloperExceptionPage();
}
else
{
	// UseExceptionHandler() -> using Microsoft.AspNetCore.Builder;
	app.UseExceptionHandler("/Errors/Error");

	// The default HSTS value is 30 days.
	// You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts
	// UseHsts() -> using Microsoft.AspNetCore.Builder; 
	app.UseHsts();
}

// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

// UseRouting() -> using Microsoft.AspNetCore.Builder;
app.UseRouting();

//// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
//app.UseAuthentication();

//// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
//app.UseAuthorization();

// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
