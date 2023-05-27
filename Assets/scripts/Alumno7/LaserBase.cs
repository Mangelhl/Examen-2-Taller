using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBase : MonoBehaviour
{
   [SerializeField] private float speed = 40;
     private Rigidbody rb2;
    

    // Update is called once per frame
    private void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb2.velocity = Vector2.right * speed ;
       
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall")) { gameObject.SetActive(false); }
        if (collision.gameObject.CompareTag("enemy")) { gameObject.SetActive(false); }

    }
}
