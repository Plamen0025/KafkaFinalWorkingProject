using KafkaFinalWorkingProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KafkaFinalWorkingProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<MongoDataService>();
            // Добавяме MongoDB MovieService
            services.AddSingleton<MovieService>();

            // Добавяме Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddSingleton<KafkaProducer>();
            services.AddSingleton<KafkaConsumer>();

            services.AddSingleton<InMemoryMovieService>();

            services.AddSingleton<FakeKafkaService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}