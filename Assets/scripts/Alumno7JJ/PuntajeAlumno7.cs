using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuntajeAlumno7 : MonoBehaviour
{
    Puntuación puntuacion;
    private float puntos;
    public TextMeshProUGUI textMeshProP;
    private Text S;
    void Start()
    {
        puntuacion = FindObjectOfType<Puntuación>();
        textMeshProP = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        textMeshProP.text = ("Score:"+puntos.ToString("0"));
        if (puntos >= 15)
        {
            puntuacion.winCondition = true;
            SceneManager.LoadScene(8);
        }
    }
    public void SumarPuntos(float puntosEntada)
    {
        puntos += puntosEntada;
    }
  
}
