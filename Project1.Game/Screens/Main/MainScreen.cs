using osu.Framework.Allocation;
using osu.Framework.Screens;

namespace Project1.Game.Screens.Main;

public partial class MainScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(),
            new ExitButton(),
            new SpinningText(),
        ];
    }
}