using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    Puntuaci�n probando;

    void Start()
    {
        probando = FindObjectOfType<Puntuaci�n>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            probando.winCondition = true;
        }
    }
}
