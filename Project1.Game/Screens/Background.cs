using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;

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
                Colour = Style.Background,
                RelativeSizeAxes = Axes.Both,
            },
            new ExitButton(),
        ];
    }
}