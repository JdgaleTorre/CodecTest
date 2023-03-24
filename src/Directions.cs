using System;

public enum Directions
{
    North,
    East,
    West,
    South,
}

public static class DirectionExtensions
{
    public static Directions TurnLeft(this Directions direction)
    {
        return direction switch
        {
            Directions.North => Directions.West,
            Directions.West => Directions.South,
            Directions.South => Directions.East,
            Directions.East => Directions.North,
            _ => throw new ArgumentException($"Invalid direction: {direction}")
        };
    }

    public static Directions TurnRight(this Directions direction)
    {
        return direction switch
        {
            Directions.North => Directions.East,
            Directions.East => Directions.South,
            Directions.South => Directions.West,
            Directions.West => Directions.North,
            _ => throw new ArgumentException($"Invalid direction: {direction}")
        };
    }

    public static (int, int) Move(this Directions direction, int x, int y, int spaces)
    {
        return direction switch
        {
            Directions.North => (x, y + spaces),
            Directions.East => (x + spaces, y),
            Directions.South => (x, y - spaces),
            Directions.West => (x - spaces, y),
            _ => throw new ArgumentException($"Invalid direction: {direction}")
        };
    }

    public static string ToString(this Directions direction)
    {
        return direction switch
        {
            Directions.North => "North",
            Directions.South => "South",
            Directions.East => "East",
            Directions.West => "West",
            _ => throw new ArgumentException($"Invalid direction: {direction}")
        };
    }
}