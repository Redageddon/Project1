using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osuTK.Graphics;

namespace Project1.Game.Screens;

public partial class ProjectButton : BasicButton
{
    public ProjectButton()
    {
        this.Padding = new MarginPadding(10);
        this.Masking = true;
        this.RelativeSizeAxes = Axes.Both;
        this.BorderColour = Colour4.Black;
        this.BorderThickness = 14;
        this.HoverColour = Color4.Gray;
        this.BackgroundColour = new Color4(100, 100, 100, 255);
    }
    
    protected override SpriteText CreateText()
    {
        return new SpriteText
        {
            Depth = -1,
            Origin = Anchor.Centre,
            Anchor = Anchor.Centre,
            Font = FrameworkFont.Regular,
            Colour = Colour4.Black,
        };
    }
}