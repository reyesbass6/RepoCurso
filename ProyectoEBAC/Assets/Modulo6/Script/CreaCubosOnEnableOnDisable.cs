using UnityEngine;
using System.Collections;

public class CreaCubosOnEnableOnDisable : MonoBehaviour
{
    GameObject cubo;
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

        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        Debug.Log("Cubo desde ONENABLE");
        crearCubo("Cubo desde ONENABLE");

    }

    private void OnDisable()
    {
        Debug.Log("Cubo desde ONDISABLE");
        crearCubo("Cubo desde ONDISABLE");
    }

    public void crearCubo(string nombre)
    {

        GameObject cuboGenerico = new GameObject(nombre);
        cuboGenerico.AddComponent<MeshFilter>();
        var meshFilter = cuboGenerico.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangles;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();

        cuboGenerico.AddComponent<BoxCollider>();
        var boxCollider = cuboGenerico.GetComponent<BoxCollider>();

        

        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        cuboGenerico.AddComponent<MeshRenderer>();
        Color c = new Color(Random.value, Random.value, Random.value);
        cuboGenerico.GetComponent<MeshRenderer>().material.color = c;

        cuboGenerico.transform.position = Vector3.one;
    }

}
