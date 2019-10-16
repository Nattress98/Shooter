using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour
{
    [SerializeField] RoadNode[] roadNodes;
    Vector3[] points;
    public float roadWidth;

    static int[] tris =
    {
                0,1,2,
                1,3,2
    };

    void Start()
    {

        Mesh mesh = new Mesh();
        //points = new Vector3[roadNodes.Length];
        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();

        for (int i = 0; i < roadNodes.Length; i++)
        {
            Transform pointA = roadNodes[i].transform;
            Transform pointB = roadNodes[i].connectedNodes[0].transform;

            pointA.LookAt(pointB);
            pointB.LookAt(pointA);

            Vector3[] v = {
                pointA.position + pointA.right,
                pointA.position - pointA.right,
                pointB.position - pointB.right,
                pointB.position + pointB.right,
            };
            foreach (int t in tris)
                triangles.Add(t + (4 * i));
            vertices.AddRange(v);
        }



        mesh.SetVertices(vertices);
        mesh.triangles = triangles.ToArray();
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
    }
}
