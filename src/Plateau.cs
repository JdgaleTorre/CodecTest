using System;

public interface IPlateau
{
    public int MaxX { get; }
    public int MaxY { get; }

    public bool IsValidPosition(int x, int y);
}
public class Plateau : IPlateau
{
    private readonly int _maxX;
    private readonly int _maxY;

    public int MaxX => _maxX;
    public int MaxY => _maxY;


    public Plateau(int maxX, int maxY)
    {
        if (maxX <= 0)
        {
            throw new ArgumentException("MaxX must be greater than 0");
        }
        if (maxY <= 0)
        {
            throw new ArgumentException("MaxY must be greater than 0");
        }
        _maxX = maxX;
        _maxY = maxY;
    }

    public bool IsValidPosition(int x, int y)
    {
        if (x < 1 || x >= MaxX || y < 1 || y >= MaxY)
        {
            return false;
        }


        return true;
    }
}
