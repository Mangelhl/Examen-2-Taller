    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RocasLunares : MonoBehaviour
{
    private Rigidbody rb3;
    DefeatCount defeat;
    [SerializeField] float speed2;
    PuntajeAlumno7 PA7;
    GameObject M;
    private void Start()
    {
       defeat = FindObjectOfType<DefeatCount>();
       
        PA7 = FindObjectOfType<PuntajeAlumno7>();
        rb3 = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb3.velocity = Vector3.left * speed2;

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            PA7.SumarPuntos(1);
            Destroy(this.gameObject);
        }
        if  (other.gameObject.CompareTag("Player"))
        {
            defeat.loseCondition = true;
            SceneManager.LoadScene(7);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }
  
}
