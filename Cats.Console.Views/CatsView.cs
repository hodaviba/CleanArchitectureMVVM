namespace Cats.Console.Views;

public class CatsView : ICatsView
{
    readonly ICatsViewModel ViewModel;

    public CatsView(ICatsViewModel viewModel)
    {
        ViewModel = viewModel;
    }

    public async Task RenderCatsAsync()
    {
        await ViewModel.GetCatAsync();

        foreach (var cat in ViewModel.Cats)
        {
            WriteTop();
            WriteMiddle(cat.Id.ToString());
            WriteMiddle(cat.Name);
            WriteMiddle(cat.Description);
            WriteMiddle(cat.BasePrice.ToString("$ #,###.00"));
            WriteBottom();
        }
    }

    void WriteTop() =>
        System.Console.WriteLine(" ╔{0}╗", new string('═', 70));

    void WriteMiddle(string text) =>
        System.Console.WriteLine(" ║ {0,-69}║", text);

    void WriteBottom() =>
        System.Console.WriteLine(" ╚{0}╝", new string('═', 70));
}