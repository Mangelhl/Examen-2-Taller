using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alumno6_Muerte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trampas"))
        {
            SceneManager.LoadScene("Pantalla_Derrota");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Trampas"))
        {
            SceneManager.LoadScene("Pantalla_Derrota");
        }
    }
}
