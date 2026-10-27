var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
builder.Services.AddHealthChecks();
var app = builder.Build();
app.MapHealthChecks("/health");
app.MapGet("/", () => new { service = "Gateway", subdomain = "api.arishmasolutions.com", status = "Phase 0 scaffold" });
app.MapReverseProxy();
app.Run();
