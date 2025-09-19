using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Events;

namespace Project1.Game.Screens.Second;

public partial class HabitTableRow(Habit habit) : CompositeDrawable
{
    private Box backgroundBox = null!;

    public Habit Habit { get; } = habit;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.X;
        this.Height = 48;

        this.InternalChildren =
        [
            this.backgroundBox = new Box
            {
                RelativeSizeAxes = Axes.Both,
                Colour = Style.DrawableUnderlay2,
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
                        new Container
                        {
                            RelativeSizeAxes = Axes.Both,
                            Padding = new MarginPadding { Horizontal = 10 },
                            Child = new SpriteText
                            {
                                Text = this.Habit.Value,
                                Font = FontUsage.Default.With(size: 20),
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                                Truncate = true,
                            },
                        },
                        new Container
                        {
                            RelativeSizeAxes = Axes.Both,
                            Padding = new MarginPadding { Horizontal = 10 },
                            Child = new SpriteText
                            {
                                Text = this.Habit.Date.ToString("yyyy-MM-dd HH:mm"),
                                Font = FontUsage.Default.With(size: 20),
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                        },
                    },
                },
            },
        ];
    }

    protected override bool OnHover(HoverEvent e)
    {
        this.backgroundBox.FadeColour(Style.Hover, 150, Easing.OutQuint);

        return base.OnHover(e);
    }

    protected override void OnHoverLost(HoverLostEvent e)
    {
        this.backgroundBox.FadeColour(Style.DrawableUnderlay2, 150, Easing.OutQuint);
        base.OnHoverLost(e);
    }
}