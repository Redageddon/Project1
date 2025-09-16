using System;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input;
using osu.Framework.Screens;
using osuTK;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    private DataGrid dataGrid;
    
    [BackgroundDependencyLoader]
    private void Load()
    {
        this.InternalChildren = 
        [
            new Background(), 
            new BackButton(this.Exit), 
            this.dataGrid = new DataGrid(40),
            new ListControls(this.Add),
        ];
    }

    public void Add(string habit)
    {
        this.dataGrid.Add(habit, DateTime.Now.ToString());
    }
}
