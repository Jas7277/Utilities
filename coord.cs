using UnityEngine;

public struct Coord
{
    public int x;
    public int y;

    public Coord(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Coord(Vector2 v)
    {
        this.x = (int)v.x;
        this.y = (int)v.y;
    }

    public Coord(Vector3 v)
    {
        this.x = (int)v.x;
        this.y = (int)v.z;
    }

    public Coord(Vector2Int v)
    {
        this.x = v.x;
        this.y = v.y;
    }

    public Coord(Vector3Int v)
    {
        this.x = v.x;
        this.y = v.z;
    }

    public static int SqrDistance (Coord a, Coord b)
    {
        return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y);
    }

    public static float Distance (Coord a, Coord b)
    {
        return (float) System.Math.Sqrt(SqrDistance(a, b));
    }

    public static bool AreNeighbours (Coord a, Coord b)
    {
        return System.Math.Abs(a.x - b.x) <= 1 && System.Math.Abs(a.y - b.y) <= 1;
    }

    public static Coord operator + (Coord a, Coord b)
    {
        return new Coord(a.x + b.x, a.y + b.y);
    }

    public static Coord operator - (Coord a, Coord b)
    {
        return new Coord(a.x - b.x, a.y - b.y);
    }

    public static bool operator == (Coord a, Coord b)
    {
        return a.x == b.x && a.y == b.y;
    }

    public static bool operator != (Coord a, Coord b)
    {
        return !(a == b);
    }

    public static implicit operator Vector2(Coord a)
    {
        return new Vector2 (a.x, a.y);
    }

    public static implicit operator Vector3(Coord a)
    {
        return new Vector3(a.x, 0, a.y);
    }

    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public override bool Equals(object obj)
    {
        return (Coord)obj == this;
    }
}
