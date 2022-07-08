using UnityEngine;
using System.Collections;

public class CreaCubosOnEnableOnDisable : MonoBehaviour
{
    public GameObject PrefabCube;

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

        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        tempGameObject.name=nombre;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

    }

}
