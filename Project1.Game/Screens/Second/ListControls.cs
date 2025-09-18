using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input;

namespace Project1.Game.Screens.Second;

public partial class ListControls : CompositeDrawable
{
    private readonly TextInput habitInput;
    private readonly Action<string> passthroughAction;
    
    public ListControls(Action<string> action)
    {
        this.passthroughAction = action;
        this.RelativeSizeAxes = Axes.Both;
        this.Size = new Vector2(0.8f, 0.1f);
        this.Anchor = Anchor.BottomCentre;
        this.Origin = Anchor.BottomCentre;
        
        this.InternalChild = new GridContainer
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
                        Text = "Habit: ",
                        Padding = new MarginPadding(10),
                        Anchor = Anchor.CentreLeft,
                        Origin = Anchor.CentreLeft,
                    },
                    this.habitInput = new TextInput
                    {
                        OnCommitAction = this.AddAction,
                    },
                    new ProjectButton
                    {
                        Text = "Add Habit",
                        Action = this.AddAction,
                    },
                },
            },
        };
    }

    private void AddAction()
    {
        if (!string.IsNullOrEmpty(this.habitInput.Text))
        {
            this.passthroughAction(this.habitInput.Text);
            this.habitInput.Text = "";

            this.FindClosestParent<IFocusManager>()?.ChangeFocus(this.habitInput);
        }
    }
}