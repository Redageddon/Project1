using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;

namespace Project1.Game.Screens.Second;

public partial class Header : GridContainer
{
    public Header(string habit, string date, int textSize)
    {
        this.RelativeSizeAxes = Axes.X;
        this.AutoSizeAxes = Axes.Y;

        this.Content = new[]
        {
            new Drawable[]
            {
                new SpriteText
                {
                    Text = habit,
                    Font = FontUsage.Default.With(size: textSize),
                    Colour = Colour4.White,
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                },
                new SpriteText
                {
                    Text = date,
                    Font = FontUsage.Default.With(size: textSize),
                    Colour = Colour4.White,
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                },
            },
        };
    }
}