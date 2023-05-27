using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefeatCount : MonoBehaviour
{
    private int loseScore;
    public bool loseCondition;


    [Header("Colocar Texto Puntaje ")]
    [SerializeField] public TMP_Text LM;

    void Start()
    {
        if (PlayerPrefs.GetInt("Muertes", 1) != 0)
        {
            loseScore = PlayerPrefs.GetInt("Muertes", 1);
        }




        LM.text = "Muertes : " + PlayerPrefs.GetInt("Muertes", 1).ToString();
    }
    private void Update()
    {

        if (loseCondition)
        {
            loseScore += 1;
            PlayerPrefs.SetInt("Muertes", loseScore);
            LM.text = "Muertes : " + loseScore.ToString();
            loseCondition = false;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("Muertes", 1);
            LM.text = "Muertes : " + 0;
        }
    }
}