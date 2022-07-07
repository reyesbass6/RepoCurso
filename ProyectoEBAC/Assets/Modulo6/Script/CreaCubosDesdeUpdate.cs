using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreaCubosDesdeUpdate : MonoBehaviour
{

    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    GameObject cuboUpdate;
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

    // Use this for initialization
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;

        cuboUpdate = new GameObject("Cubo Desde Codigo UPDATE");
        cuboUpdate.AddComponent<MeshFilter>();
        var meshFilter = cuboUpdate.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangles;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();

        cuboUpdate.AddComponent<BoxCollider>();
        var boxCollider = cuboUpdate.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(2f, 0.5f, 0.5f);

        cuboUpdate.AddComponent<MeshRenderer>();

        Color c = new Color(Random.value, Random.value, Random.value);
        cuboUpdate.GetComponent<MeshRenderer>().material.color = c;

        cuboUpdate.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(cuboUpdate);

        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;

            if (escala <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }
        foreach (GameObject go in objetosParaEliminar)
        {
            objetosParaEliminar.Remove(go);
            Destroy(go);
        }
    }
}
