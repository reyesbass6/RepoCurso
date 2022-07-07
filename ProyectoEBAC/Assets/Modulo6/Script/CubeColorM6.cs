using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorM6 : MonoBehaviour
{

    public GameObject PrefabCube;
    GameObject tempCube;


    public void Awake()
    {
        Debug.Log("Hola desde AWAKE CubeColorM6");
        tempCube = Instantiate<GameObject>(PrefabCube);
        Color color = new Color(Random.value, Random.value, Random.value);
        tempCube.GetComponent<MeshRenderer>().material.color = color;
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
