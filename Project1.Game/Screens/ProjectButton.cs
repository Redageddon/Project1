using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;

namespace Project1.Game.Screens;

public partial class ProjectButton : BasicButton
{
    public ProjectButton()
    {
        this.Padding = new MarginPadding(8);
        this.Masking = true;
        this.RelativeSizeAxes = Axes.Both;
        this.BorderThickness = 14;
        this.HoverColour = Style.Hover;
        this.BorderColour = Style.Boarder;
        this.BackgroundColour = Style.DrawableUnderlay1;
    }

    protected override SpriteText CreateText()
    {
        return new SpriteText
        {
            Depth = -1,
            Origin = Anchor.Centre,
            Anchor = Anchor.Centre,
            Font = FrameworkFont.Regular,
            Colour = Style.Text,
        };
    }
}