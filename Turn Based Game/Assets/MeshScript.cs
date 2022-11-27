using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScript : MonoBehaviour
{
    private Vector3[] points;
    public Vector3[] save;
    public Mesh Mesh;
    public MeshFilter filter;
    public Vector3 vertices;
    private int[] triangles;
    private Vector2[] uv;
        void Start()
    {
        SetValues();
    }

    // Update is called once per frame
    void Update()
    {
       DrawBar(); 
    }

    void DrawBar()
    {
        Mesh = new Mesh();
        points = save;
        Mesh.vertices = points;
        Mesh.triangles = new int[12]
        {
            1,2,0,
            1,3,2,
            4,3,1,
            4,5,3,
            
        };
        
        Mesh.uv = new Vector2[6]
        {
            new Vector2(0, 0),
            new Vector2(0, 0),
            new Vector2(0, 0),
            new Vector2(0, 0),
            new Vector2(0, 0),
            new Vector2(0, 0),
        };
        filter.mesh = Mesh;
    }

    void SetValues()
    {
        save = new Vector3[6]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 1.5f, 0),
            new Vector3(.5f, 0, 0),
            new Vector3(.5f,1.5f,0),
            new Vector3(.10f, 0,0),
            new Vector3(.10f,1.5f,0),
            
        };
    }
}
