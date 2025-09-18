using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Platform;
using osuTK;
using osuTK.Graphics;

namespace Project1.Game.Screens;

public partial class ExitButton : BasicButton
{
    public ExitButton()
    {
        this.Anchor = Anchor.TopRight;
        this.Origin = Anchor.TopRight;
        this.Text = "X";
        this.BackgroundColour = Color4.Black;
        this.Size = new Vector2(40, 40);
        this.HoverColour = Color4.Gray;
        this.SpriteText.Colour = Color4.Red;
    }

    [BackgroundDependencyLoader]
    private void Load(GameHost host)
    {
        this.Action += host.Exit;
    }
}