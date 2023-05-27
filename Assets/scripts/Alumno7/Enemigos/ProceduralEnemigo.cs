using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ProceduralEnemigo : MonoBehaviour
{
    private float MinX, MaxX, MinY, MaxY,MinZ,MaxZ;
    [Space] [Header("Tiempo de Aparición")]
    [SerializeField] private int tiempospawn;
    [Space] [Header("Asignarle los Puntos de Spawn")]
 [SerializeField,Tooltip("Crea los puntos de spawn")] private Transform[] TransfSpawn;
    [Space][Header("Asignarle los enemigos")]
    [SerializeField,Tooltip("Crea Tus Enemigos")] private GameObject[] Enemigo;
    [Space]
    float TiempoNuevoEnemigoM;
    NaveJugador NJ;
    // Start is called before the first frame update
    void Start()
    {
        NJ= FindObjectOfType<NaveJugador>();
      
     
        MaxX = TransfSpawn.Max(Punto => Punto.position.x);
        MinX = TransfSpawn.Min(Punto => Punto.position.x);
        MaxY = TransfSpawn.Max(Punto => Punto.position.y);
        MinY = TransfSpawn.Min(Punto => Punto.position.y);
        MinZ = TransfSpawn.Max(Punto => Punto.position.z);
        MinZ = TransfSpawn.Min(Punto => Punto.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (NJ.P == true)
        {
            TiempoNuevoEnemigoM += Time.deltaTime;
            if (TiempoNuevoEnemigoM >= tiempospawn)
            {
                TiempoNuevoEnemigoM = 0;
                CrearEnemigo();
            }
        }
    }
    private void CrearEnemigo()
    {
        int NEnemigo = Random.Range(0, Enemigo.Length);
        Vector2 posicionAleatoria = new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));

        Instantiate(Enemigo[NEnemigo], posicionAleatoria, Quaternion.identity);
    
    }
    
}
