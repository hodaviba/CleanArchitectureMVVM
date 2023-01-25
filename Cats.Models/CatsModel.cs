namespace Cats.Models;

public class CatsModel : ICatsModel
{
    readonly HttpClient Client;
    readonly CatsEndpoints Endpoints;

    public CatsModel(HttpClient client, CatsEndpoints endpoints)
    {
        Client = client;
        Endpoints = endpoints;
    }

    public async Task<IReadOnlyCollection<Cat>> GetCatsAsync() => await Client.GetFromJsonAsync<IReadOnlyCollection<Cat>>(Endpoints.cats);
}