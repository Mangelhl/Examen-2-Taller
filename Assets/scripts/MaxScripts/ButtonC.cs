using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonC : MonoBehaviour
{
    [SerializeField] private int nScene;
    public void IrAEscena() 
    {
        SceneManager.LoadScene(nScene);
    }
}
