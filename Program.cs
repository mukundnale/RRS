

using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.Repo.RailwayReservationRepository;
using Railway_Reservation.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RailwayContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ModelCS")));

builder.Services.AddScoped<ITrainRepository, TrainRepository>();
builder.Services.AddScoped<IPassenger, PassengerRepository>();
builder.Services.AddScoped<IPayment, PaymentRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
