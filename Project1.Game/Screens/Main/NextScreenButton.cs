using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK;
using osuTK.Graphics;

namespace Project1.Game.Screens.Main;

public partial class NextScreenButton : BasicButton
{
    public NextScreenButton(Action onPressed)
    {
        this.Action = onPressed;
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;
        this.Text = "Next Screen";
        this.BackgroundColour = Color4.Black;
        this.Size = new Vector2(400, 40);
        this.HoverColour = Color4.Gray;
        this.SpriteText.Colour = Color4.Red;
    }
}