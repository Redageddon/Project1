using System;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;

namespace Project1.Game.Screens.Second;

public partial class HabitControls : CompositeDrawable
{
    private HabitTextBox textBox = null!;

    public event Action<string> OnHabitAdded;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.X;
        this.Height = 60;
        this.Anchor = Anchor.BottomCentre;
        this.Origin = Anchor.BottomCentre;

        this.InternalChild = new Container
        {
            RelativeSizeAxes = Axes.Both,
            Width = 0.8f,
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Child = new GridContainer
            {
                RelativeSizeAxes = Axes.Both,
                ColumnDimensions =
                [
                    new Dimension(GridSizeMode.AutoSize),
                ],
                Content = new[]
                {
                    new Drawable[]
                    {
                        new SpriteText
                        {
                            Text = "Add habit: ",
                            Font = FontUsage.Default.With(size: 20),
                            Anchor = Anchor.CentreLeft,
                            Origin = Anchor.CentreLeft,
                            Margin = new MarginPadding { Right = 10 },
                        },
                        this.textBox = new HabitTextBox
                        {
                            PlaceholderText = "Enter habit...",
                        },
                        new ProjectButton
                        {
                            Text = "Add",
                            Action = this.TryAddHabit,
                            Margin = new MarginPadding { Left = 10 },
                        },
                    },
                },
            },
        };
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
        this.textBox.OnCommit += (_, _) => this.TryAddHabit();
    }

    private void TryAddHabit()
    {
        if (string.IsNullOrWhiteSpace(this.textBox.Text))
        {
            return;
        }

        this.OnHabitAdded?.Invoke(this.textBox.Text);
        this.textBox.Text = string.Empty;

        this.Schedule(() => this.GetContainingFocusManager()?.ChangeFocus(this.textBox));
    }
}