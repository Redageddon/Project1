using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK.Graphics;

namespace Project1.Game.Screens.Second;

public partial class TextInput : BasicTextBox
{
    public TextInput()
    {
        this.BackgroundUnfocused = new Color4(100, 100, 100, 255);
        this.BackgroundFocused = new Color4(70, 70, 70, 255);
    }
}