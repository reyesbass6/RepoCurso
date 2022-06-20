using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Mensaje normal");
        Debug.Log("Hola Mundo - Prueba de log");
        Debug.LogError("Mensaje de Error");
        Debug.LogWarning("Mensaje de Alerta");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
