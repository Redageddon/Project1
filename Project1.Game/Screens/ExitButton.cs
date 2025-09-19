using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Platform;
using osuTK;

namespace Project1.Game.Screens;

public partial class ExitButton : BasicButton
{
    public ExitButton()
    {
        this.Anchor = Anchor.TopRight;
        this.Origin = Anchor.TopRight;
        this.Text = "X";
        this.Size = new Vector2(40, 40);
        this.HoverColour = Style.Hover;
        this.SpriteText.Colour = Style.Danger;
        this.BackgroundColour = Style.DrawableUnderlay1;
    }

    [BackgroundDependencyLoader]
    private void Load(GameHost host)
    {
        this.Action += host.Exit;
    }
}