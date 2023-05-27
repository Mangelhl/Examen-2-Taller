using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NaveJugador :MonoBehaviour
{

    [SerializeField] public bool P;
    private float h, v;
    private float speed = 2.5f;
    private Rigidbody rb;
    [SerializeField] private Transform bulletPosition;
    [SerializeField] private GameObject bulletPrefab;
    ProceduralEnemigo PE;
    private void Start()
    {
       P = false;
        PE = FindObjectOfType<ProceduralEnemigo>();
        PE = GetComponent<ProceduralEnemigo>();
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        h = (Input.GetAxisRaw("Horizontal"));
        v = (Input.GetAxisRaw("Vertical"));
        if (Input.GetButtonDown("Fire1"))
        { Fire(); }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(h*speed, v*speed);
      
    }

    private void Fire() {
        GameObject bullet = PoolObjectNAVE.instance.GetPooledObject();

        if (bullet != null) {
            bullet.transform.position = bulletPosition.position;
            bullet.SetActive(true);
        }
    }
    public void EEOK() 
    {
   P=true;
    }
   
}
