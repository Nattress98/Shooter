using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Intersection
{
    public List<Point> points;
    public Intersection(List<Point> _points)
    {
        points = _points;
    }
    public override bool Equals(object other)
    {
        int c = 0;
        Intersection inter = (Intersection) other;
        foreach (Point p in inter.points)
            if (this.points.Exists(f => f == p))
                c++;
        
        return c== this.points.Count && c == inter.points.Count;
    }

    public override int GetHashCode()
    {
        return -501195594 + EqualityComparer<List<Point>>.Default.GetHashCode(points);
    }
}
