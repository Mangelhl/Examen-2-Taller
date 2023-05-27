using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampas : MonoBehaviour
{
    public bool Aleatoriedad;
    public int CuantasVecesSalioTrampa = 0;
 
    [Header("GameObjects")]
    public GameObject UnoUno;
    public GameObject UnoDos;
    public GameObject UnoTres;
    public GameObject DosUno;
    public GameObject DosDos;
    public GameObject DosTres;
    public GameObject TresUno;
    public GameObject TresDos;
    public GameObject TresTres;
    [Header("Colores")]
    public Color verdeTransparenteColor = new Color(0.33f, 1f, 0f, 0.3f);
   
    public Color RojoColor = new Color(1f, 0f, 0f, 1f);
    private void Start()
    {
        UnoUno.SetActive(false);
        UnoDos.SetActive(false);
        UnoTres.SetActive(false);
        DosUno.SetActive(false);
        DosDos.SetActive(false);
        DosTres.SetActive(false);
        TresUno.SetActive(false);
        TresDos.SetActive(false);
        TresTres.SetActive(false);


        int NumAleatorioStart = Random.Range(1, 3);
        if (NumAleatorioStart == 1)
        {
            InvokeRepeating("Repetir", 2f, 0.5f);
            Aleatoriedad = true;
        }
        if (NumAleatorioStart == 2)
        {
            InvokeRepeating("Repetir", 2f, 1.5f);
            Aleatoriedad = false;
        }
    }
    private void Update()
    {
       
    }
    public void Repetir()
    {
        if(Aleatoriedad)
        {
            TrampasPorFilasYColumnas();
            CuantasVecesSalioTrampa = CuantasVecesSalioTrampa + 3;

        }
        else
        {
            TrampasAleatorias();
            CuantasVecesSalioTrampa = CuantasVecesSalioTrampa + 1;
        }

    }
    public void TrampasPorFilasYColumnas()
    {
        int NumAleatorio = Random.Range(1, 9);
        Debug.Log(NumAleatorio);
        switch (NumAleatorio)
        {
            case 1:
                StartCoroutine(UNOuno());
                StartCoroutine(UNOdos());
                StartCoroutine(UNOtres());
                break;
            case 2:
                StartCoroutine(DOSuno());
                StartCoroutine(DOSdos());
                StartCoroutine(DOStres());
                break;
            case 3:
                StartCoroutine(TRESuno());
                StartCoroutine(TRESdos());
                StartCoroutine(TREStres());
                break;
            case 4:
                StartCoroutine(UNOuno());
                StartCoroutine(DOSuno());
                StartCoroutine(TRESuno());
                break;
            case 5:
                StartCoroutine(UNOdos());
                StartCoroutine(DOSdos());
                StartCoroutine(TRESdos());
                break;
            case 6:
                StartCoroutine(UNOtres());
                StartCoroutine(DOStres());
                StartCoroutine(TREStres());
                break;
            case 7:
                StartCoroutine(UNOuno());
                StartCoroutine(DOSdos());
                StartCoroutine(TREStres());
                break;
            case 8:
                StartCoroutine(UNOtres());
                StartCoroutine(DOSdos());
                StartCoroutine(TRESuno());  
                break;
            
        }
    }
    public void TrampasAleatorias()
    {
        int NumAleatorio = Random.Range(1, 10);
        Debug.Log(NumAleatorio);
        switch (NumAleatorio)
        {
            case 1:
                StartCoroutine(UNOuno());
                break;
            case 2:
                StartCoroutine(UNOdos());
                break;
            case 3:
                StartCoroutine(UNOtres());
                break;
            case 4:
                StartCoroutine(DOSuno());
                break;
            case 5:
                StartCoroutine(DOSdos());
                break;
            case 6:
                StartCoroutine(DOStres());
                break;
            case 7:
                StartCoroutine(TRESuno());
                break;
            case 8:
                StartCoroutine(TRESdos());
                break;
            case 9:
                StartCoroutine(TREStres());
                break;
        }
    }
    
    IEnumerator UNOuno()
    {
        UnoUno.SetActive(true);
        UnoUno.tag = "avisoTrampa";
        UnoUno.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        UnoUno.tag = "Trampas";
        UnoUno.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        UnoUno.SetActive(false);
    }
    IEnumerator UNOdos()
    {
        UnoDos.SetActive(true);
        UnoDos.tag = "avisoTrampa";
        UnoDos.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        UnoDos.tag = "Trampas";
        UnoDos.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        UnoDos.SetActive(false);
    }
    IEnumerator UNOtres()
    {
        UnoTres.SetActive(true);
        UnoTres.tag = "avisoTrampa";
        UnoTres.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        UnoTres.tag = "Trampas";
        UnoTres.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        UnoTres.SetActive(false);
    }
    IEnumerator DOSuno()
    {
        DosUno.SetActive(true);
        DosUno.tag = "avisoTrampa";
        DosUno.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        DosUno.tag = "Trampas";
        DosUno.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        DosUno.SetActive(false);
    }
    IEnumerator DOSdos()
    {
        DosDos.SetActive(true);
        DosDos.tag = "avisoTrampa";
        DosDos.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        DosDos.tag = "Trampas";
        DosDos.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        DosDos.SetActive(false);
    }
    IEnumerator DOStres()
    {
        DosTres.SetActive(true);
        DosTres.tag = "avisoTrampa";
        DosTres.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        DosTres.tag = "Trampas";
        DosTres.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        DosTres.SetActive(false);
    }
    IEnumerator TRESuno()
    {
        TresUno.SetActive(true);
        TresUno.tag = "avisoTrampa";
        TresUno.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        TresUno.tag = "Trampas";
        TresUno.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        TresUno.SetActive(false);
    }
    IEnumerator TRESdos()
    {
        TresDos.SetActive(true);
        TresDos.tag = "avisoTrampa";
        TresDos.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        TresDos.tag = "Trampas";
        TresDos.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        TresDos.SetActive(false);
    }
    IEnumerator TREStres()
    {
        TresTres.SetActive(true);
        TresTres.tag = "avisoTrampa";
        TresTres.GetComponent<Renderer>().material.color = verdeTransparenteColor;
        yield return new WaitForSeconds(2f);
        TresTres.tag = "Trampas";
        TresTres.GetComponent<Renderer>().material.color = RojoColor;
        yield return new WaitForSeconds(1f);
        TresTres.SetActive(false);
    }
}
