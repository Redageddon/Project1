using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace Project1.Game.Screens;

public partial class BackButton : BasicButton
{
    public BackButton(Action onPressed)
    {
        this.Action = onPressed;
        this.Anchor = Anchor.BottomLeft;
        this.Origin = Anchor.BottomLeft;
        this.Text = "BACK";
        this.Size = new Vector2(100, 40);
        this.HoverColour = Style.Hover;
        this.SpriteText.Colour = Style.Danger;
        this.BackgroundColour = Style.DrawableUnderlay1;
    }
}