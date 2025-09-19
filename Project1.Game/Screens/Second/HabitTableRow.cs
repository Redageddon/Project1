using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Events;
using osuTK.Input;
using Project1.Game.IO;

namespace Project1.Game.Screens.Second;

public partial class HabitTableRow(Habit habit) : CompositeDrawable
{
    private Box left, right;
    
    [Resolved]
    private HabitStorage HabitStorage { get; set; } = null!;

    public Habit Habit { get; } = habit;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.X;
        this.Height = 48;

        this.InternalChildren =
        [
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
                            /*BorderColour = Style.Boarder,
                            BorderThickness = 4,
                            Masking = true,*/
                            Children =
                            [
                                this.left = new Box
                                {
                                    RelativeSizeAxes = Axes.Both,
                                    Colour = Style.DrawableUnderlay2,
                                },
                                new SpriteText
                                {
                                    Anchor = Anchor.Centre,
                                    Origin = Anchor.Centre,
                                    Text = this.Habit.Value,
                                    Font = FontUsage.Default.With(size: 20),
                                    Truncate = true,
                                },
                            ],
                        },
                        new Container
                        {
                            RelativeSizeAxes = Axes.Both,
                            /*BorderColour = Style.Boarder,
                            BorderThickness = 4,
                            Masking = true,*/
                            Children =
                            [
                                this.right = new Box
                                {
                                    RelativeSizeAxes = Axes.Both,
                                    Colour = Style.DrawableUnderlay2,
                                },
                                new SpriteText
                                {
                                    Anchor = Anchor.Centre,
                                    Origin = Anchor.Centre,
                                    Text = this.Habit.Date.ToString("yyyy-MM-dd HH:mm"),
                                    Font = FontUsage.Default.With(size: 20),
                                },
                            ],
                        },
                    },
                },
            },
        ];
    }

    protected override bool OnHover(HoverEvent e)
    {
        this.left.FadeColour(Style.Hover, 300, Easing.OutQuint);
        this.right.FadeColour(Style.Hover, 300, Easing.OutQuint);

        return base.OnHover(e);
    }

    protected override void OnHoverLost(HoverLostEvent e)
    {
        this.left.FadeColour(Style.DrawableUnderlay2, 300, Easing.OutQuint);
        this.right.FadeColour(Style.DrawableUnderlay2, 300, Easing.OutQuint);
        base.OnHoverLost(e);
    }
    
    protected override bool OnMouseDown(MouseDownEvent e)
    {
        if (e.Button == MouseButton.Right)
        {
            this.HabitStorage.RemoveHabit(this.Habit);
            
            return true;
        }

        return base.OnMouseDown(e);
    }
}