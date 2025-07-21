using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Application.Interfaces.IRepository.IBaseRepo;
using BloodBank.Application.Interfaces.IRepository.IHelperRepo;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using BloodBank.Application.Interfaces.IServices.IBase_Services;
using BloodBank.Application.Interfaces.IServices.IHelperService;
using BloodBank.Application.Services.AuthenticationService.Donor;
using BloodBank.Application.Services.BaseService;
using BloodBank.Application.Services.HelperService;
using BloodBank.Infrastructure.AuthenticationRepo.DonorRepo;
using BloodBank.Infrastructure.Base_Repository;
using BloodBank.Infrastructure.DbContext;
using BloodBank.Infrastructure.HelperRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<IBloodGroupRepository, BloodGroupRepository>();
builder.Services.AddScoped<IBloodGroupService, BloodGroupService>();
builder.Services.AddScoped<IDonorRegistrationService, DonorRegistrationService>();
builder.Services.AddScoped<IDonorRegistration, DonorRegistration>();
builder.Services.AddScoped<IUserValidationRepo,UserValidationRepo>();
builder.Services.AddScoped<IUserValidationService, UserValidationService>();    


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
