using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using osu.Framework.Allocation;
using osu.Framework.Screens;

namespace Project1.Game.Screens.Second;

public partial class SecondScreen : Screen
{
    private DataGrid dataGrid;
    private List<Habit> habits = [];
    
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

        if (File.Exists("habits.json"))
        {
            this.habits = JsonConvert.DeserializeObject<List<Habit>>(File.ReadAllText("habits.json"));
            this.dataGrid.AddRange(this.habits);
        }
    }

    public void Add(string habitType)
    {
        Habit habit = new()
        {
            Value = habitType, 
            Date = DateTime.Now,
        };
        
        this.dataGrid.Add(habit);
        this.habits.Add(habit);

        string data = JsonConvert.SerializeObject(this.habits);
        File.WriteAllText("habits.json", data);
    }
}