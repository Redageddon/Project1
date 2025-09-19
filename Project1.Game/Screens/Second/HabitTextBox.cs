using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input.Events;

namespace Project1.Game.Screens.Second;

public partial class HabitTextBox : BasicTextBox
{
    protected override float CaretWidth => 2;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.Both;
        this.BorderThickness = 2;
        this.BorderColour = Style.Boarder;
        this.BackgroundUnfocused = Style.DrawableUnderlay1;
        this.BackgroundFocused = Style.DrawableUnderlay2;

        this.Padding = new MarginPadding
        {
            Horizontal = 10,
            Vertical = 8,
        };
    }

    protected override Drawable GetDrawableCharacter(char c)
    {
        return new FallingDownContainer
        {
            AutoSizeAxes = Axes.Both,
            Child = new SpriteText
            {
                Colour = Style.Text,
                Text = c.ToString(),
                Font = FrameworkFont.Condensed.With(size: this.FontSize),
            },
        };
    }

    protected override SpriteText CreatePlaceholder()
    {
        return new FadingPlaceholderText
        {
            Font = FrameworkFont.Condensed,
            Colour = Style.Text,
            Anchor = Anchor.CentreLeft,
            Origin = Anchor.CentreLeft,
            X = this.CaretWidth,
        };
    }

    protected override bool OnHover(HoverEvent e)
    {
        this.Colour = Style.Hover;
        
        return base.OnHover(e);
    }

    protected override void OnHoverLost(HoverLostEvent e)
    {
        this.Colour = Style.Text;
        base.OnHoverLost(e);
    }

    protected override void OnFocus(FocusEvent e)
    {
        this.Colour = Style.Text;
        base.OnFocus(e);
    }

    protected override void OnFocusLost(FocusLostEvent e)
    {
        this.Colour = Style.Text;
        base.OnFocusLost(e);
    }
}