using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceCandTextS : MonoBehaviour
{
    public float idleTime = 5f;
    private bool isInterfaceVisible = true;
    private float timeSinceLastInput = 0f;

    public string[] Contenido;
    public float scrollSpeed = 2f;

    private Text textComponent;
    private int currentIndex = 0;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = Contenido[currentIndex];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowInterface();
            timeSinceLastInput = 0f;
        }
        else
        {
            timeSinceLastInput += Time.deltaTime;

            if (timeSinceLastInput >= idleTime)
            {
                HideInterface();
            }
        }

        if (!isInterfaceVisible)
        {
            transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

            if (transform.position.x > Screen.width)
            {
                transform.position = new Vector3(-Screen.width, transform.position.y, transform.position.z);
                currentIndex = (currentIndex + 1) % Contenido.Length;
                textComponent.text = Contenido[currentIndex];
            }
        }
    }

    private void ShowInterface()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }

        isInterfaceVisible = true;
    }

    private void HideInterface()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

        isInterfaceVisible = false;
    }
}