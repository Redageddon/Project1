using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Screens;

namespace Project1.Game.Screens.Third;

public partial class ThirdScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load(TextureStore textures)
    {
        this.InternalChildren =
        [
            new Background(), 
            new Sprite
            {
                Texture = textures.Get("todo"),
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
            },
            new BackButton(this.Exit), 
        ];
    }
}