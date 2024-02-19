using Api;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddModule(config);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.AddEndpoints();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHealthChecks("/health-checks");

app.Run();