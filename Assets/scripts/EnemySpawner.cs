using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 5f;
    public float spawnAreaSize = 10f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    private void SpawnEnemy()
    {
        float spawnX = Random.Range(-10f, 10f); // Rango horizontal de generación de enemigos en el eje X
        float spawnZ = Random.Range(-10f, 10f); // Rango horizontal de generación de enemigos en el eje Z
        Vector3 spawnPosition = new Vector3(spawnX, 20f, spawnZ);
        Quaternion spawnRotation = Quaternion.identity;
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, spawnRotation);
        Destroy(enemy, 5f); // Destruir el enemigo después de 10 segundos
    }
}