using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private GameObject Buttons;
    [SerializeField] private GameObject Text;   

    public float idleTime = 5f;       
    private float timeSinceLastInput = 0f;           

    private void Start()
    {
        
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
    }

    private void ShowInterface()
    {        
        Buttons.SetActive(true);
        Text.SetActive(false);
    }

    private void HideInterface()
    {       
        Buttons.SetActive(false);
        Text.SetActive(true);
    }
}

