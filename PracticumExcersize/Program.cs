using _2_Services;
using _2_Services.Interfaces;
using _2_Services.Services;



namespace _1_UI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //builder.Services.AddControllers();
            builder.Services.AddControllers().AddNewtonsoftJson();
            builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
            builder.Services.AddScoped<IChildrenService, ChildrenService>();
            builder.Services.AddAutoMapper(typeof(Mapping));
            builder.Services.AddServices();
            //builder.Services.AddAutoMapper(typeof(Mapper));

            //Services.Extensions.AddRepoDependencies( builder.Services);
            //   builder.Services.AddRepoDependencies();

            var app = builder.Build();
            app.UseCors("corsPolicy");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
