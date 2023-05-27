using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresenemigo : MonoBehaviour
{
    public float range;
    public Transform player;
    public GameObject BulletPrefab;
    public float delay;
    private bool controladordedisparo;
    public float distancia;
    public float life = 10;
    void Start()
    {
        GameObject jugador = GameObject.Find("personaje");
        player = jugador.transform;
    }

    void Update()
    {
        range = Vector3.Distance(transform.position,player.position);
        if (range > distancia && controladordedisparo) 
        {
            Shoot();
            StartCoroutine(control());
        }
        Timers();
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Timers()
    {
        if (delay > 1)
        {
            delay -= Time.deltaTime;
        }
    }
    void Shoot()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
        controladordedisparo = false;
    }
    IEnumerator control()
    {
        yield return new WaitForSeconds(delay);
        controladordedisparo = true;
    }
   
    private void OnTriggerEnter3D(Collider cos)
    {
        if (cos.gameObject.CompareTag("balajugador"))
        {
            life -= 4;
        }
        if (life ==0)
        {
            Destroy(gameObject);

        }
    }
}

