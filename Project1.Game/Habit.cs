using System;

namespace Project1.Game;

public struct Habit : IEquatable<Habit>
{
    public string Value { get; set; }

    public DateTimeOffset Date { get; set; }
    
    public bool Equals(Habit other)
    {
        return this.Value == other.Value
            && this.Date.Equals(other.Date);
    }

    public override bool Equals(object obj)
    {
        return obj is Habit other && this.Equals(other);
    }

    public override readonly int GetHashCode()
    {
        return HashCode.Combine(this.Value, this.Date);
    }
    
    public static bool operator ==(Habit left, Habit right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Habit left, Habit right)
    {
        return !(left == right);
    }
}