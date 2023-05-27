using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{

    public int creditClicks = 0;
    public int nivel1Clicks = 0;
    public int nivel2Clicks = 0;
    public int nivel3Clicks = 0;
    public int nivel4Clicks = 0;
    public int nivel5Clicks = 0;

    public Text CreditClicksText;
    public Text Nivel1ClicksText;
    public Text Nivel2ClicksText;
    public Text Nivel3ClicksText;
    public Text Nivel4ClicksText;
    public Text Nivel5ClicksText;
   
    public void IncrementCreditClicks()
    {
        creditClicks++;
        UpdateInterface();
    }

    public void IncrementNivel1Clicks()
    {
        nivel1Clicks++;
        UpdateInterface();
    }

    public void IncrementNivel2Clicks()
    {
        nivel2Clicks++;
        UpdateInterface();
    }

    public void IncrementNivel3Clicks()
    {
        nivel3Clicks++;
        UpdateInterface();
    }

    public void IncrementNivel4Clicks()
    {
        nivel4Clicks++;
        UpdateInterface();
    }

    public void IncrementNivel5Clicks()
    {
        nivel5Clicks++;
        UpdateInterface();
    }

    public void UpdateInterface()
    {
        CreditClicksText.text = "Créditos: " + creditClicks.ToString();
        Nivel1ClicksText.text = "Nivel 1: " + nivel1Clicks.ToString();
        Nivel2ClicksText.text = "Nivel 2: " + nivel2Clicks.ToString();
        Nivel3ClicksText.text = "Nivel 1: " + nivel3Clicks.ToString();
        Nivel4ClicksText.text = "Nivel 2: " + nivel4Clicks.ToString();
        Nivel5ClicksText.text = "Nivel 2: " + nivel5Clicks.ToString();
    }
}
