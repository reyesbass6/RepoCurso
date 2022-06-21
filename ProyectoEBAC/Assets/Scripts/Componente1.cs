using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public static GameObject miObjeto;
    // Start is called before the first frame update

    private void Awake()
    {
        miObjeto = this.gameObject;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
