using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Web
{
  public class Startup
  {
      IConfiguration Configuration;
      public Startup(IConfiguration configuration) {
          Configuration = configuration;
      }
      public void ConfigureServices(IServiceCollection services){
          services.AddControllersWithViews();
      }
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
          if (env.IsDevelopment())
          {
          app.UseDeveloperExceptionPage();
          }
          app.UseRouting();
          app.UseStaticFiles();
          app.UseEndpoints(endpoints =>
          {
              endpoints.MapAreaControllerRoute(
                  name: "Giris",
                  areaName: "Login",
                  pattern: "Giris/{controller=Login}/{action=Index}/{id?}"
              );
              endpoints.MapAreaControllerRoute(
                  name: "MENU",
                  areaName: "MENU",
                  pattern: "MENU/{controller=Start}/{action=Index}/{id?}"
              );

              endpoints.MapControllerRoute(
                  name: "default",
                  pattern:"{controller=AnaSayfa}/{action=Index}/{id?}"
                  );
          });
      }
  }
}
