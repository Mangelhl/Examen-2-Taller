using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuación : MonoBehaviour
{
    private int winScore;
    public bool winCondition;

    
    [Header("Colocar Texto Puntaje ")]
    [SerializeField] public TMP_Text SM;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) != 0) 
        {
            winScore = PlayerPrefs.GetInt("Puntaje Maximo", 0);
        }

      


        SM.text = "MaxScore : " + PlayerPrefs.GetInt("Puntaje Maximo", 0).ToString();
    }
    private void Update()
    {

        if (winCondition)
        {
            winScore += 1;
            PlayerPrefs.SetInt("Puntaje Maximo", winScore);
            SM.text = "MaxScore : " + winScore.ToString();
            winCondition = false;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("Puntaje Maximo", 0);
            SM.text = "MaxScore : " + 0;
        }
    }
}
