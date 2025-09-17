using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace Project1.Game.Screens.Second;

public partial class ListControls : CompositeDrawable
{
    private TextInput habitInput;
    private BasicButton addButton;
    private Action<string> passthroughAction;
    
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
            Content = new[]
            {
                new Drawable[]
                {
                    this.habitInput = new TextInput
                    {
                        Padding = new MarginPadding(10),
                        RelativeSizeAxes = Axes.Both,
                        BorderColour = Colour4.Black,
                        BorderThickness = 2,
                    },
                    this.addButton = new BasicButton
                    {
                        Padding = new MarginPadding(10),
                        Masking = true,
                        RelativeSizeAxes = Axes.Both,
                        BorderColour = Colour4.Green,
                        BorderThickness = 2,
                        Text = "Add Habit",
                    },
                },
            },
        };

        this.addButton.Action = this.AddAction;
    }

    private void AddAction()
    {
        if (!string.IsNullOrEmpty(this.habitInput.Text))
        {
            this.passthroughAction(this.habitInput.Text);
            this.habitInput.Text = "";
        }
    }
}