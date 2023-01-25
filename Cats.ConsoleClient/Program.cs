// See https://aka.ms/new-console-template for more information
Console.WriteLine("Consulta de Gatos");

var host = DependencyInjectionHost.CreateDefaullHost();

host.Services.AddConsoleServices(
    host.Configuration.GetSection("CatsEndpoints").Get<CatsEndpoints>());

host.Build();

var view = host.GetRequiredService<ICatsView>();
await view.RenderCatsAsync();