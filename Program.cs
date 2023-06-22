using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Areas.Identity.Data;
using Pharmacy.Data;
using Pharmacy.Repository;
using Pharmacy.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("PharmacyContextConnection") ?? throw new InvalidOperationException("Connection string 'PharmacyContextConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<PharmacyUser>()
    .AddRoles<IdentityRole<int>>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthorization(o =>
{
    o.AddPolicy("IsDoctor", policy => policy.RequireRole(UserRoles.Doctor));
    o.AddPolicy("IsPatient", policy => policy.RequireRole(UserRoles.Patient));
    o.AddPolicy("IsPharmacist", policy => policy.RequireRole(UserRoles.Pharmacist));
    o.AddPolicy("IsNurse", policy => policy.RequireRole(UserRoles.Nurse));
});

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddScoped<IPets, PetsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
