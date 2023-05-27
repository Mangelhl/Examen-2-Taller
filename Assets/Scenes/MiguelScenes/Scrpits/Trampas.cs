using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampas : MonoBehaviour
{
    public bool Aleatoriedad;
    public int CuantasTrampasSalen;

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
    public Color verdeTransparente;
    public Color Rojo;


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
        int NumeroRandomStart = Random.Range(1, 3);
        switch (NumeroRandomStart)
        {
            case 1:
                Aleatoriedad = true;
                InvokeRepeating("Repetidor", 2f, 0.5f);
                break;
            case 2:
                Aleatoriedad = false;
                InvokeRepeating("Repetidor", 2f, 2f);
                break;
        }

    }
    public void Repetidor()
    {
        if(Aleatoriedad)
        {
            TrampasAleatorias();
        }
        else
        {
            TrampasFilasColumnas();
        }
    }
    public void TrampasAleatorias()
    {
        int NumeroRandom = Random.Range(1, 10);
        CuantasTrampasSalen = CuantasTrampasSalen + 1;
        switch(NumeroRandom)
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
    public void TrampasFilasColumnas()
    {
        int NumeroRandom = Random.Range(1, 9);
        CuantasTrampasSalen = CuantasTrampasSalen + 3;
        switch (NumeroRandom)
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
                StartCoroutine(TRESuno());
                StartCoroutine(DOSdos());
                StartCoroutine(UNOtres());
                break;
           
        }
    }
    IEnumerator UNOuno()
    {
        UnoUno.SetActive(true);
        UnoUno.GetComponent<Renderer>().material.color = verdeTransparente;
        UnoUno.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        UnoUno.tag = "Trampas";
        UnoUno.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        UnoUno.SetActive(false);
    }

    IEnumerator UNOdos()
    {
        UnoDos.SetActive(true);
        UnoDos.GetComponent<Renderer>().material.color = verdeTransparente;
        UnoDos.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        UnoDos.tag = "Trampas";
        UnoDos.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        UnoDos.SetActive(false);
    }

    IEnumerator UNOtres()
    {
        UnoTres.SetActive(true);
        UnoTres.GetComponent<Renderer>().material.color = verdeTransparente;
        UnoTres.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        UnoTres.tag = "Trampas";
        UnoTres.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        UnoTres.SetActive(false);
    }

    IEnumerator DOSuno()
    {
        DosUno.SetActive(true);
        DosUno.GetComponent<Renderer>().material.color = verdeTransparente;
        DosUno.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        DosUno.tag = "Trampas";
        DosUno.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        DosUno.SetActive(false);
    }

    IEnumerator DOSdos()
    {
        DosDos.SetActive(true);
        DosDos.GetComponent<Renderer>().material.color = verdeTransparente;
        DosDos.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        DosDos.tag = "Trampas";
        DosDos.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        DosDos.SetActive(false);
    }

    IEnumerator DOStres()
    {
        DosTres.SetActive(true);
        DosTres.GetComponent<Renderer>().material.color = verdeTransparente;
        DosTres.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        DosTres.tag = "Trampas";
        DosTres.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        DosTres.SetActive(false);
    }

    IEnumerator TRESuno()
    {
        TresUno.SetActive(true);
        TresUno.GetComponent<Renderer>().material.color = verdeTransparente;
        TresUno.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        TresUno.tag = "Trampas";
        TresUno.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        TresUno.SetActive(false);
    }

    IEnumerator TRESdos()
    {
        TresDos.SetActive(true);
        TresDos.GetComponent<Renderer>().material.color = verdeTransparente;
        TresDos.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        TresDos.tag = "Trampas";
        TresDos.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        TresDos.SetActive(false);
    }

    IEnumerator TREStres()
    {
        TresTres.SetActive(true);
        TresTres.GetComponent<Renderer>().material.color = verdeTransparente;
        TresTres.tag = "avisoTrampa";
        yield return new WaitForSeconds(2f);
        TresTres.tag = "Trampas";
        TresTres.GetComponent<Renderer>().material.color = Rojo;
        yield return new WaitForSeconds(1f);
        TresTres.SetActive(false);
    }
}
