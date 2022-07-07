using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboDesdeCodigo : MonoBehaviour
{
    GameObject objToSpawn, objToSpawn2;

    int x,z;

    Vector3[] vertices = {
    new Vector3 (0, 0, 0),
    new Vector3 (1, 0, 0),
    new Vector3 (1, 1, 0),
    new Vector3 (0, 1, 0),
    new Vector3 (0, 1, 1),
    new Vector3 (1, 1, 1),
    new Vector3 (1, 0, 1),
    new Vector3 (0, 0, 1),
};


    int[] triangles = {
    0, 2, 1, //face front
	0, 3, 2,
    2, 3, 4, //face top
	2, 4, 5,
    1, 2, 5, //face right
	1, 5, 6,
    0, 7, 4, //face left
	0, 4, 3,
    5, 4, 7, //face back
	5, 7, 6,
    0, 6, 7, //face bottom
	0, 1, 6
};


    Vector3[] vertices2 = {
    new Vector3 (0, 1, 0),
    new Vector3 (2, 1, 0),
    new Vector3 (0, 0, 0),
    new Vector3 (2, 0, 0),
};

    int[] triangles2 = {
    0, 3, 2, //face front
	0, 1, 1

};



    // Start is called before the first frame update
    void Start()
    {

        x = 10;
        z = 0;

        objToSpawn = new GameObject("Cubo Desde Codigo");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangles;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();

        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.clear;

        objToSpawn.transform.position = Vector3.one;





        objToSpawn2 = new GameObject("Prisma Desde Codigo");
        objToSpawn2.AddComponent<MeshFilter>();
        var meshFilter2 = objToSpawn2.GetComponent<MeshFilter>().mesh;
        meshFilter2.Clear();
        meshFilter2.vertices = vertices2;
        meshFilter2.triangles = triangles2;
        meshFilter2.Optimize();
        meshFilter2.RecalculateNormals();

        objToSpawn2.AddComponent<BoxCollider>();
        var boxCollider2 = objToSpawn2.GetComponent<BoxCollider>();
        boxCollider2.center = new Vector3(0.5f, 0.5f, 0.5f);

        objToSpawn2.AddComponent<MeshRenderer>();
        var meshRendererMaterial2 = objToSpawn2.GetComponent<MeshRenderer>().material;
        meshRendererMaterial2.color = Color.clear;

        objToSpawn2.transform.position = new Vector3(3f, 1f, 1f);







    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {

            objToSpawn.transform.position = new Vector3(x, 1f, z);

                if (x >= 0)
                {
                    z++;
                }
                else { z--; }

                if (z <= 10)
                {
                    x++;
                }
                else
                {
                    x--;
                }
      
    }
}