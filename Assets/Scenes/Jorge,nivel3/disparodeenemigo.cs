using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparodeenemigo : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public Rigidbody rb3d;
    private Vector3 direcionjugador;
    public float timer;
    public float maxTimer;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
        direcionjugador = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position ).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Timer();
    }
    void Move()
    {

        rb3d.velocity = direcionjugador * speed;
        

    }
    void Timer()
    {
        timer += Time.deltaTime;
        if (timer >= maxTimer)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        
    }
}
