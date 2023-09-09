var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Health Check
builder.Services.AddHealthChecks();
builder.Services.AddHealthChecksUI()
                .AddInMemoryStorage();

var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI();

//Removendo a condição 2

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRouting()
    .UseEndpoints(config => config.MapHealthChecksUI());

app.Run();
