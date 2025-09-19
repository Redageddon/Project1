using osu.Framework.Allocation;
using osu.Framework.Screens;
using Project1.Game.IO;

namespace Project1.Game.Screens.Third;

public partial class ThirdScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren =
        [
            new Background(), 
            new BackButton(this.Exit), 
        ];
    }
}