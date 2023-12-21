using ProjectOrthodontics;
using ProjectOrthodontics.Core.Repositories;
using ProjectOrthodontics.Core.Services;
using ProjectOrthodontics.Service;
using ProjectOrtodontics.Data.Repositories;
using ProjectOrthodontics.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IDataContext,DataContext>();
builder.Services.AddScoped<IDoctorService,DoctorService>();

builder.Services.AddScoped<IDoctorRepository,DoctorRepository>();

builder.Services.AddScoped<IAppointmentRepository,AppointmentRepository>();

builder.Services.AddScoped<IAppointmentService,AppointmentService>();

builder.Services.AddScoped<IPatientRepository,PatientRepository>();

builder.Services.AddScoped<IPatientService,PatientService>();

//builder.Services.AddSingleton<DataContext>();

builder.Services.AddDbContext<DataContext>();

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

