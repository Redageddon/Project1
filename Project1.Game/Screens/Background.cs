using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK.Graphics;
using Project1.Game.Screens.Main;

namespace Project1.Game.Screens;

public partial class Background : CompositeDrawable
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.Both;

        this.InternalChildren =
        [
            new Box
            {
                Colour = new Color4(55, 55, 55, 255),
                RelativeSizeAxes = Axes.Both,
            },
            new ExitButton(),
        ];
    }
}