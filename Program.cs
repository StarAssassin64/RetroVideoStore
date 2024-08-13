using Microsoft.EntityFrameworkCore;
using RetroVideoStore.Components;
using RetroVideoStore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<RentalContext>(options =>
    options.UseSqlite("Data Source = RetroVideoStore.db"));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDbContext<OrderContext>(options =>
    options.UseSqlite("Data Source = RetroVideoStore.db"));
builder.Services.AddDbContextFactory<RentalContext>(lifetime: ServiceLifetime.Scoped);
builder.Services.AddDbContextFactory<OrderContext>(lifetime: ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
