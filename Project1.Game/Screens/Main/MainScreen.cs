using osu.Framework;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Platform;
using osu.Framework.Screens;
using osuTK.Graphics;

namespace Project1.Game.Screens.Main;

public partial class MainScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(),
            new SpinningText(),
            new ExitButton(),
        ];
    }
}