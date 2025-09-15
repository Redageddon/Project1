using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
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
            new Box
            {
                Colour = new Color4(55, 55, 55, 255),
                RelativeSizeAxes = Axes.Both,
            },
            new SpinningText(),
        ];
    }
}