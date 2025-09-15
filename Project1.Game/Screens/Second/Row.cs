using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;

namespace Project1.Game.Screens.Second;

public partial class Row : GridContainer
{
    public Row(string habit, string date, int textSize)
    {
        this.RelativeSizeAxes = Axes.X;
        this.AutoSizeAxes = Axes.Y;

        this.ColumnDimensions =
        [
            new Dimension(GridSizeMode.Relative, 0.5f),
            new Dimension(GridSizeMode.Relative, 0.5f),
        ];

        this.Content = new[]
        {
            new Drawable[]
            {
                new SpriteText
                {
                    Text = habit,
                    Font = FontUsage.Default.With(size: textSize, weight: "regular"),
                    Colour = Colour4.White,
                },
                new SpriteText
                {
                    Text = date,
                    Font = FontUsage.Default.With(size: textSize, weight: "regular"),
                    Colour = Colour4.White,
                },
            },
        };
    }
}