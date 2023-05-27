using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CountManager : MonoBehaviour
{
    public TextMeshProUGUI texto1;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            StaticVariables.CreditsTimes++;
            texto1.text = StaticVariables.CreditsTimes.ToString();
        }
        if (SceneManager.GetActiveScene().name == "Nivel1")
        {
            StaticVariables.Nivel1Times++;
            texto1.text = StaticVariables.Nivel1Times.ToString();
        }
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            StaticVariables.Nivel2Times++;
            texto1.text = StaticVariables.Nivel2Times.ToString();
        }
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {
            StaticVariables.Nivel3Times++;
            texto1.text = StaticVariables.Nivel3Times.ToString();
        }
        if (SceneManager.GetActiveScene().name == "Nivel14")
        {
            StaticVariables.Nivel4Times++;
            texto1.text = StaticVariables.Nivel4Times.ToString();
        }
        if (SceneManager.GetActiveScene().name == "Nivel5")
        {
            StaticVariables.Nivel5Times++;
            texto1.text = StaticVariables.Nivel5Times.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
