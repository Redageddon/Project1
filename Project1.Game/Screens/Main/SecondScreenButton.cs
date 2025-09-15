using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK;
using osuTK.Graphics;

namespace Project1.Game.Screens.Main;

public partial class SecondScreenButton : BasicButton
{
    public SecondScreenButton(Action onPressed)
    {
        this.Action = onPressed;
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;
        this.Text = "Hello";
        this.BackgroundColour = Color4.Black;
        this.Size = new Vector2(400, 40);
        this.HoverColour = Color4.Gray;
        this.SpriteText.Colour = Color4.Red;
    }
}