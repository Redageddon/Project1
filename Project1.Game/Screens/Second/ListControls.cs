using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace Project1.Game.Screens.Second;

public partial class ListControls : CompositeDrawable
{
    public ListControls(Action<string> action)
    {
        this.RelativeSizeAxes = Axes.Both;
        this.Size = new Vector2(0.8f, 0.1f);
        this.Anchor = Anchor.BottomCentre;
        this.Origin = Anchor.BottomCentre;
        BasicTextBox habitInput;
        
        this.InternalChild = new GridContainer
        {
            RelativeSizeAxes = Axes.Both,
            Content = new[]
            {
                new Drawable[]
                {
                    habitInput = new BasicTextBox
                    {
                        RelativeSizeAxes = Axes.Both,
                        BorderColour = Colour4.Black,
                        BorderThickness = 2,
                    },
                    new BasicButton
                    {
                        Masking = true,
                        RelativeSizeAxes = Axes.Both,
                        BorderColour = Colour4.Green,
                        BorderThickness = 2,
                        Action = () => action(habitInput.Text),
                    },
                },
            },
        };
    }   
}