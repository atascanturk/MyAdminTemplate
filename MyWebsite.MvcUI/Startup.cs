using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.DependencyResolvers;
using MyWebsite.Core.Entities.Concrete;
using MyWebsite.Core.Extensions;
using MyWebsite.Core.Utilities.IoC;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Mvc.Filters;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.AutoMapper.Profiles;
using MyWebsite.MvcUI.Helpers.Concrete;
using MyWebsite.MvcUI.Middlewares;
using MyWebsite.Services.Extensions;
using System;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(options =>
            {
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "Bu alan bo� ge�ilmemelidir.");
                options.Filters.Add<MvcExceptionFilter>(); //filtre eklemek i�in gerekli komut.            


            }).AddRazorRuntimeCompilation().AddNToastNotifyNoty(); ;

            services.AddAutoMapper(typeof(ViewModelsProfile), typeof(UserProfile), typeof(NewsProfile),
                typeof(AnnouncementProfile), typeof(VideoProfile), typeof(AdministrativeStaffProfile), typeof(AlertProfile), typeof(ProjectProfile));

            //Global Properties Keeping in Static Class         
            GlobalProperties.DbConn = Configuration.GetConnectionString("Database").ToString();


            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IMusicHelper, MusicHelper>();
            services.Configure<SmtpSettings>(Configuration.GetSection("SmtpSettings"));
            services.Configure<EmailSendDto>(Configuration.GetSection("EmailSendDto"));
            services.LoadMyServices();
            services.AddSession();
            services.AddMvc();
            services.AddLogging();
            services.AddHttpClient();
            services.AddHttpContextAccessor();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/WNqGRjUh3JPe/Auth/Login");
                options.LogoutPath = new PathString("/WNqGRjUh3JPe/Auth/Logout");
                options.Cookie = new CookieBuilder
                {
                    Name = "MyWebSite",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.Always //Always
                };
                options.SlidingExpiration = true;
                options.Events.OnSigningIn = ctx =>
                {
                    if (ctx.Properties.IsPersistent)
                    {

                        ctx.Properties.IssuedUtc = DateTime.Now;
                        ctx.Properties.IsPersistent = true;
                        ctx.Properties.ExpiresUtc = ctx.Properties.IssuedUtc.Value.AddDays(3);
                    }

                    else
                    {
                        ctx.Properties.IssuedUtc = DateTime.Now;
                        ctx.Properties.IsPersistent = true;
                        ctx.Properties.ExpiresUtc = ctx.Properties.IssuedUtc.Value.AddMinutes(30);
                    }
                    return Task.FromResult(0);
                };
                options.AccessDeniedPath = new PathString("/WNqGRjUh3JPe/Auth/AccessDenied");

            });

            services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();

            }
            else
            {
                app.UseExceptionHandler("/Error/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStatusCodePagesWithReExecute("/Error/Error", "?code={0}");            
            app.UseStaticFiles();
            app.UseMiddleware<VisitorCounterMiddleware>();
            app.UseMiddleware<CheckIsUnderMaintenanceMiddleware>();
            app.UseMiddleware<SetSEOMiddleware>();
            app.UseRouting();
            app.UseAuthentication(); // Kimlik kontrol�
            app.UseAuthorization(); // Yetki kontrol�            
            app.UseSession();
            app.UseNToastNotify();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"

                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{FriendlyUrl?}");
            });
        }
    }
}
