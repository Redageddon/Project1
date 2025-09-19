using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace Project1.Game.Screens.Main;

public partial class ScreenButton : BasicButton
{
    public ScreenButton(Action onPressed)
    {
        this.Action = onPressed;
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;
        this.Size = new Vector2(400, 40);
        this.HoverColour = Style.Hover;
        this.SpriteText.Colour = Style.Danger;
        this.BackgroundColour = Style.DrawableUnderlay1;
    }
}