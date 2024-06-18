using Backoffice;
using HVVAny.Components;
using Streckennetz;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<StreckennetzUndTarifDatenbank>();
builder.Services.AddSingleton<Session, SimpleBackofficeImplentation>();


builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
