using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{

    public float idleTime = 5f; 
    public Text scrollingText; 
    public bool isInterfaceVisible = true;
    private float timeSinceLastInput = 0f;
    private string[] textContents; 
    private TextScrolling textScrolling; // Referencia al script de desplazamiento de texto

    private void Start()
    {
        // Inicializa el contenido del texto en movimiento
        textContents = new string[] { "Texto 1", "Texto 2", "Texto 3" };

        // Obtener referencia al script de desplazamiento de texto
        textScrolling = GetComponentInChildren<TextScrolling>();

        // Iniciar el desplazamiento de texto
        textScrolling.StartScrolling(textContents);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // El jugador hizo clic, muestra la interfaz y reinicia el tiempo de inactividad
            ShowInterface();
            timeSinceLastInput = 0f;
        }
        else
        {
            // Incrementa el tiempo de inactividad
            timeSinceLastInput += Time.deltaTime;

            if (timeSinceLastInput >= idleTime)
            {
                // El jugador estuvo inactivo durante el tiempo especificado, oculta la interfaz
                HideInterface();
            }
        }
    }

    private void ShowInterface()
    {
        // Activa todos los elementos de la interfaz
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }

        isInterfaceVisible = true;
        textScrolling.enabled = false; // Desactivar el desplazamiento de texto
    }

    private void HideInterface()
    {
        // Desactiva todos los elementos de la interfaz
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

        isInterfaceVisible = false;
        textScrolling.enabled = true; // Activar el desplazamiento de texto
    }
}

