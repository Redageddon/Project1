using osu.Framework.Allocation;
using osu.Framework.Screens;
using Project1.Game.Screens.Second;

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
            new NextScreenButton(() => this.Push(new SecondScreen())),
        ];
    }
}