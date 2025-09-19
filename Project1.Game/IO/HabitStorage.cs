using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using osu.Framework.Bindables;
using osu.Framework.Platform;

namespace Project1.Game.IO;

public class HabitStorage(Storage storage)
{
    private const string Filename = "habits.json";

    public readonly BindableList<Habit> Habits = [];

    public void Load()
    {
        if (!storage.Exists(Filename))
        {
            return;
        }

        try
        {
            using Stream stream = storage.GetStream(Filename);
            using StreamReader reader = new(stream);

            string json = reader.ReadToEnd();
            List<Habit> habits = JsonConvert.DeserializeObject<List<Habit>>(json) ?? new List<Habit>();

            this.Habits.Clear();
            this.Habits.AddRange(habits);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to load habits: {ex}");
        }
    }

    public void Save()
    {
        using Stream stream = storage.CreateFileSafely(Filename);
        using StreamWriter writer = new(stream);

        string json = JsonConvert.SerializeObject(this.Habits.ToArray(), Formatting.Indented);
        writer.Write(json);
    }

    public void AddHabit(string name)
    {
        Habit habit = new()
        {
            Value = name,
            Date = DateTimeOffset.Now,
        };

        this.Habits.Add(habit);
        this.Save();
    }
}