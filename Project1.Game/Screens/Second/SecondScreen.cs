using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Screens;
using osuTK;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        DataGrid dataGrid = new(40);
        dataGrid.Add("ASD", "2025-09-15");
        dataGrid.Add("ZXC", "2025-09-14");
        dataGrid.Add("QWE", "2025-09-13");

        this.InternalChildren = 
        [
            new Background(), 
            new BackButton(this.Exit), 
            dataGrid.ScrollContainer,
        ];
    }
}
