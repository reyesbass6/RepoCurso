using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColorM6 : MonoBehaviour
{

    public GameObject PrefabSphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola desde UPDATE SphereColorM6");
        Color color = new Color(Random.value, Random.value, Random.value);
        PrefabSphere.GetComponent<MeshRenderer>().material.color = color;
    }

    
}
