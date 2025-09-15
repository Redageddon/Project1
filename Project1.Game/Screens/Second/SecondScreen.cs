using osu.Framework.Allocation;
using osu.Framework.Screens;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(),
            new BackButton(this.Exit),
        ];
    }
}