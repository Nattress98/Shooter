using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point 
{
    public Vector2 position;
    public Road road;
    public Point() { }
    public Point(Vector2 _position, Road _road = null)
    {
        position = _position;
        road = _road;
    }
    public Vector3 GetVector3()
    {
        return new Vector3(position.x, 0, position.y);
    }
    public override bool Equals(object other)
    {
        return (Vector2.Distance((other as Point).position, position) <  0.01f);
    }





    //stfu
    public override int GetHashCode()
    {
        var hashCode = -2062639563;
        hashCode = hashCode * -1521134295 + EqualityComparer<Vector2>.Default.GetHashCode(position);
        hashCode = hashCode * -1521134295 + EqualityComparer<Road>.Default.GetHashCode(road);
        return hashCode;
    }
}
