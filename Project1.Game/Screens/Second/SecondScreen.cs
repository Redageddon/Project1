using System;
using osu.Framework.Allocation;
using osu.Framework.Screens;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    [BackgroundDependencyLoader]
    private void Load()
    {
        DataGrid dataGrid = new(40);

        Random random = new();
        
        for (int i = 0; i < 100; i++)
        {
            dataGrid.Add(random.Next().ToString(), "2025-09-15");
        }

        this.InternalChildren = 
        [
            new Background(), 
            new BackButton(this.Exit), 
            dataGrid,
        ];
    }
}
