using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColorM6 : MonoBehaviour
{
     public GameObject PrefabCapsula;
    GameObject capsule;

     void Awake()
    {
       


    }
    // Start is called before the first frame update

    void Start()
    {
         capsule = Instantiate<GameObject>(PrefabCapsula);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola desde FIXEDUPDATE CapsuleColorM6");
        Color color = new Color(Random.value, Random.value, Random.value);


        capsule.GetComponent<MeshRenderer>().material.color = color;
    }
}
