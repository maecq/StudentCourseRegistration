using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentCourseRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentCourseRegistration.Data;
using System.Text.Json;
using StudentCourseRegistration.Models;
using Microsoft.AspNetCore.Http;

namespace StudentCourseRegistration
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
            services.AddRazorPages();
            services.AddTransient<JsonFileCoursesService>();
            services.AddTransient<JsonFileInstructorsService>();
            services.AddTransient<JsonFileStudentsService>();
            services.AddControllers();
            services.AddServerSideBlazor();

            services.AddDbContext<StudentCourseRegistrationContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("StudentCourseRegistrationContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                //endpoints.MapGet("/instructors", (context) =>
                //{
                //    var instructors = app.ApplicationServices.GetService<JsonFileInstructorsService>().GetInstructors();
                //    var json = JsonSerializer.Serialize<IEnumerable<Instructor>>(instructors);
                //    return context.Response.WriteAsync(json);
                //});
            });
        }
    }
}
