using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;

namespace Project1.Game.Screens.Second;

public partial class HabitTableHeader : CompositeDrawable
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.X;
        this.Height = 50;

        this.InternalChildren =
        [
            new Box
            {
                RelativeSizeAxes = Axes.Both,
                Colour = Style.DrawableUnderlay1,
            },
            new GridContainer
            {
                RelativeSizeAxes = Axes.Both,
                ColumnDimensions = 
                [
                    new Dimension(), 
                    new Dimension(),
                ],
                Content = new[]
                {
                    new Drawable[]
                    {
                        new SpriteText
                        {
                            Text = "Habit",
                            Font = FontUsage.Default.With(size: 24),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                        },
                        new SpriteText
                        {
                            Text = "Date",
                            Font = FontUsage.Default.With(size: 24),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                        },
                    },
                },
            },
        ];
    }
}