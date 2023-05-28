using Travelopia.Assignment.Business.IServices;
using Travelopia.Assignment.Business.Services;
using Travelopia.Assignment.Data.IRepository;
using Travelopia.Assignment.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITravelSurveyRepository, TravelSurveyRepository>();
builder.Services.AddScoped<ITravelSurveyService, TravelSurveyService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();
app.Run();