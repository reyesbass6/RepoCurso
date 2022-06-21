using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    private void Awake()
    {
        Debug.Log("Hola desde AWAKE");
    }

    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        /*print("Mensaje normal");
        Debug.Log("Hola Mundo - Prueba de log");
        Debug.LogError("Mensaje de Error");
        Debug.LogWarning("Mensaje de Alerta");
        */

        Debug.Log("Hola desde START");

    }

    // Update is called once per frame
    void Update()
    {
        /*x += 1;
         Debug.Log(x);
        */

        Debug.Log("Hola desde UPDATE");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola desde FIXEDUPDATE cada 50 frames");
        x += 1;

        Componente1.miObjeto.name = Componente1.miObjeto.name + x;
        Debug.Log("Cada 50 frames me cambian el nombre, ahora me llamo: "+ Componente1.miObjeto.name);
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LATE UPDATE");
    }

    private void OnEnable()
    {
        Debug.Log("Hola desde ONENABLE");

    }

    private void OnDisable()
    {
        Debug.Log("Hola desde DISABLE");
    }
}
