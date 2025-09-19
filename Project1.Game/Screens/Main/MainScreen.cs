using osu.Framework.Allocation;
using osu.Framework.Screens;
using osuTK;
using Project1.Game.Screens.Second;
using Project1.Game.Screens.Third;

namespace Project1.Game.Screens.Main;

public partial class MainScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(),
            new ScreenButton(() => this.Push(new SecondScreen()))
            {
                Text = "Open Habits' List",
                Position = new Vector2(0, -40),
            },
            new ScreenButton(() => this.Push(new ThirdScreen()))
            {
                Text = "Open Indecision Machine",
                Position = new Vector2(0, 40),
            },
        ];
    }
}