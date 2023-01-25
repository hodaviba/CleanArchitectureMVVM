namespace Cats.BusinessObjects.Interfaces;

public interface ICatsViewModel
{
    IReadOnlyCollection<Cat> Cats { get; }

    Task GetCatAsync();
}
