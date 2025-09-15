using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osuTK.Graphics;

namespace Project1.Game.Screens;

public partial class Background : Box
{
    public Background()
    {
        this.Colour = new Color4(55, 55, 55, 255);
        this.RelativeSizeAxes = Axes.Both;
    }
}