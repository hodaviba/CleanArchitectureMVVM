namespace Cats.BusinessObjects.Interfaces;

public interface ICatsModel
{
    Task<IReadOnlyCollection<Cat>> GetCatsAsync();
}
