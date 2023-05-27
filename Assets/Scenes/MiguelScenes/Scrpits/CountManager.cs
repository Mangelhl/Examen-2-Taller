using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CountManager : MonoBehaviour
{
    public TextMeshProUGUI textocreditos;
    public TextMeshProUGUI texto1;
    public TextMeshProUGUI texto2;
    public TextMeshProUGUI texto3;
    public TextMeshProUGUI texto4;
    public TextMeshProUGUI texto5;


    // Start is called before the first frame update
    void Start()
    {
        textocreditos.text = StaticVariables.CreditsTimes.ToString();
        texto1.text = StaticVariables.Nivel1Times.ToString();
        texto2.text = StaticVariables.Nivel2Times.ToString();
        texto3.text = StaticVariables.Nivel3Times.ToString();
        texto4.text = StaticVariables.Nivel4Times.ToString();
        texto5.text = StaticVariables.Nivel5Times.ToString();              
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CreditsRestart()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.CreditsTimes++;
            textocreditos.text = StaticVariables.CreditsTimes.ToString();
        }
    }

    public void Nivel1Restart()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.Nivel1Times++;
            texto1.text = StaticVariables.Nivel1Times.ToString();
        }
    }

    public void Nivel2Restart()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.Nivel2Times++;
            texto2.text = StaticVariables.Nivel2Times.ToString();
        }
    }
    public void Nivel3Restart()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.Nivel3Times++;
            texto3.text = StaticVariables.Nivel3Times.ToString();
        }
    }

    public void Nivel4Restart()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.Nivel4Times++;
            texto4.text = StaticVariables.Nivel4Times.ToString();
        }
    }

    public void Nivel5Restart()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.Nivel5Times++;
            texto5.text = StaticVariables.Nivel5Times.ToString();
        }
    }
}
