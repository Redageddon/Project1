using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input.Events;
using osuTK.Graphics;

namespace Project1.Game.Screens.Second;

public partial class TextInput : BasicTextBox
{
    public Action OnCommitAction { get; init; }

    protected override float CaretWidth => 4;
    
    public TextInput()
    {
        this.Padding = new MarginPadding(10);
        this.RelativeSizeAxes = Axes.Both;
        this.BorderColour = Colour4.Black;
        this.BorderThickness = 14;
        this.BackgroundUnfocused = new Color4(100, 100, 100, 255);
        this.BackgroundFocused = new Color4(70, 70, 70, 255);
    }

    protected override void OnTextCommitted(bool textChanged)
    {
        base.OnTextCommitted(true);

        this.OnCommitAction();
    }

    protected override bool OnHover(HoverEvent e)
    {
        this.BackgroundUnfocused = new Color4(255, 255, 255, 100);
        
        return base.OnHover(e);
    }
    
    protected override void OnHoverLost(HoverLostEvent e)
    {
        this.BackgroundUnfocused = new Color4(100, 100, 100, 255);
        
        base.OnHoverLost(e);
    }
}