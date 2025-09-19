using osu.Framework.Allocation;
using osu.Framework.Screens;
using Project1.Game.IO;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    private SecondScreenContent content = null!;

    [Resolved]
    private HabitStorage HabitStorage { get; set; } = null!;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(), 
            new BackButton(this.Exit), 
            this.content = new SecondScreenContent(),
        ];
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
        this.HabitStorage.Load();
    }
}