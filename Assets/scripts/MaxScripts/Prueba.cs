using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    Puntuación probando;

    void Start()
    {
        probando = FindObjectOfType<Puntuación>();

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
