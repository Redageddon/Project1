using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK;
using osuTK.Graphics;

namespace Project1.Game.Screens.Second;

public partial class BackButton : BasicButton
{
    public BackButton(Action onPressed)
    {
        this.Action = onPressed;
        this.Anchor = Anchor.BottomCentre;
        this.Origin = Anchor.BottomCentre;
        this.Text = "Exit";
        this.BackgroundColour = Color4.Black;
        this.Size = new Vector2(100, 40);
        this.HoverColour = Color4.Gray;
        this.SpriteText.Colour = Color4.White;
    }
}