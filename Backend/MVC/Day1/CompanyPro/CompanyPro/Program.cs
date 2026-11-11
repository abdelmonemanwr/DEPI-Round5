using CompanyPro.Enums;
using CompanyPro.Repositories;

namespace CompanyPro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<DepartmentRepository>();
            //builder.Services.AddScoped<IPaymentProvider, PayPalPaymentProvider>(PaymentProviderEnum.PayPal);
            //builder.Services.AddScoped<IPaymentProvider, VodafonePaymentProvider>(PaymentProviderEnum.VodafoneCash);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Use(async (httpContext, next) =>
            {
                string username = httpContext.Request.Cookies["Username"] ?? "Guest";
                httpContext.Response.Cookies.Append("LastVisit", DateTime.UtcNow.ToString());
                //await httpContext.Response.WriteAsync($"hello {username}, cookie has been set successfully");
                await next.Invoke();
                // extra logic
                //await httpContext.Response.WriteAsync($"bye bye {username}");
            });

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            //// locaaa:34343/admin/users/getall?pagenum=2&...
            //app.MapControllerRoute(
            //    name: "areas",
            //    pattern: "{areas=Exists}/{controller=Home}/{action=Index}/{id?}")
            //    .WithStaticAssets();

            app.Run();
        }
    }
}
