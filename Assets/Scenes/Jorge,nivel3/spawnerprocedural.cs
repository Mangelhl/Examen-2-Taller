using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerprocedural : MonoBehaviour
{
    public float timer;
    public float maxTimer;
    public GameObject objectPrefab;
    public GameObject currentObject;
    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        if (currentObject)
        {
            timer += Time.deltaTime;
            if (timer >= maxTimer)
            {
                GameObject obj = Instantiate(objectPrefab);
                Vector3 temporalPosition = transform.position;
                
                obj.transform.position = temporalPosition;
                maxTimer = Random.Range(10f, 20f);
                timer = 0;
                currentObject = obj;
            }
        }
    }
}
