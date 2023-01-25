namespace Cats.ViewModels;

public class CatsViewModel : ICatsViewModel
{
    readonly ICatsModel Model;

    public CatsViewModel(ICatsModel model)
    {
        Model = model;
    }

    public IReadOnlyCollection<Cat> Cats { get; private set; }

    public async Task GetCatAsync()
    {
        Cats = await Model.GetCatsAsync();
    }
}