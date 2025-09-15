using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(),
            new BackButton(this.Exit),
            new SpriteText
            {
                Y = 20,
                Text = "Hello World",
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Font = FontUsage.Default.With(size: 40),
            },
        ];
    }
}