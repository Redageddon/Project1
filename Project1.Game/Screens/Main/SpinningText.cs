using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;
using osuTK.Graphics;

namespace Project1.Game.Screens.Main;

public partial class SpinningText : CompositeDrawable
{
    private Container box;

    public SpinningText()
    {
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;
    }

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChild = this.box = new Container
        {
            AutoSizeAxes = Axes.Both,
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Children =
            [
                new Box
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(400, 100),
                    Colour = Color4.Black,
                },
                new SpriteText
                {
                    Text = "Hello World!",
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Font = FontUsage.Default.With(size: 40),
                },
            ],
        };
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
        this.box.Loop(b => b.RotateTo(0).RotateTo(360, 2500));
    }
}