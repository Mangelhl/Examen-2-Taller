using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickCredits : MonoBehaviour
{
    private int creditClicks;    

    [Header("Colocar Texto Puntaje ")]
    [SerializeField] public TMP_Text SM;

    void Start()
    {
        if (PlayerPrefs.GetInt("Creditos", 2) != 0)
        {
            creditClicks = PlayerPrefs.GetInt("Creditos", 2);
        }
        SM.text = "Clicks : " + PlayerPrefs.GetInt("Creditos", 2).ToString();
    }
    private void Update()
    {     

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("Creditos", 2);
            SM.text = "Clicks : " + 0;
        }
    }

    public void Count()
    {
        creditClicks += 1;
        PlayerPrefs.SetInt("Creditos", creditClicks);
        SM.text = "Clicks : " + creditClicks.ToString();
    }

    
}
