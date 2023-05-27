using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PuntajeAlumno7 : MonoBehaviour
{
    private float puntos;
    public TextMeshProUGUI textMeshProP;
    private Text S;
    void Start()
    {
        textMeshProP = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        textMeshProP.text = ("Score:"+puntos.ToString("0"));
    }
    public void SumarPuntos(float puntosEntada)
    {
        puntos += puntosEntada;
    }
  
}
