using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaCuboAwake : MonoBehaviour
{
    GameObject cuboAwake;
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




    private void Awake()
    {
        Debug.Log("Hola, creando desde AWAKE");

        cuboAwake = new GameObject("Cubo Desde Codigo AWAKE");
        cuboAwake.AddComponent<MeshFilter>();
        var meshFilter = cuboAwake.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangles;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();

        cuboAwake.AddComponent<BoxCollider>();
        var boxCollider = cuboAwake.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        cuboAwake.AddComponent<MeshRenderer>();
        var meshRendererMaterial = cuboAwake.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.green;

        cuboAwake.transform.position = Vector3.one;



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
