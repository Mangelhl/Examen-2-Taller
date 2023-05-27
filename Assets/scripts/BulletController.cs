using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;

    private void Start()
    {
        Destroy(gameObject, 5f); // Destruir la bala después de 5 segundos
    }

    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage); // Infligir daño al enemigo
            }
            Destroy(gameObject); // Destruir la bala al colisionar con un enemigo
        }
    }
}
