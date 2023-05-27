using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScrolling : MonoBehaviour
{
    public string[] Contenido;
    public float scrollSpeed = 2f;

    private Text textComponent;
    private int currentIndex = 0;

    
    void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = Contenido[currentIndex];
    }
    public void StartScrolling(string[] textContents)
    {
        Contenido = textContents;
        textComponent.text = Contenido[currentIndex];
    }

    private void Update()
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
