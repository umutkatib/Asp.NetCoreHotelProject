using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.WebApi.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HotelProject.WebApi
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
            services.AddDbContext<HotelProjectContext>();

			services.AddAutoMapper(cfg => cfg.AddMaps(typeof(Program).Assembly)); 
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<ITrailerDal, EfTrailerDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<IBookingDal, EfBookingDal>();

			services.AddScoped<IServiceService, ServiceManager>();
			services.AddScoped<ISubscribeService, SubscribeManager>();
			services.AddScoped<IStaffService, StaffManager>();      
			services.AddScoped<ITestimonialService, TestimonialManager>();
			services.AddScoped<IRoomService, RoomManager>();
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<ITrailerService, TrailerManager>();
			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<ISocialMediaService, SocialMediaManager>();
			services.AddScoped<IBookingService, BookingManager>();

            services.AddCors(opt =>
            {
                opt.AddPolicy("OtelApiCors", opt =>
                {
                    opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

			services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProject.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelProject.WebApi v1"));
            }

            app.UseRouting();
            app.UseCors("OtelApiCors");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
