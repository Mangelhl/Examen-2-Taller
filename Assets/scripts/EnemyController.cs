using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float fallSpeed = 2f;
    public int maxHealth = 1;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject); // Destruir el jugador
        }
        else if (other.CompareTag("Bullet"))
        {
            BulletController bullet = other.GetComponent<BulletController>();
            if (bullet != null)
            {
                TakeDamage(bullet.damage); // Recibir daño del jugador
                Destroy(other.gameObject); // Destruir la bala
            }
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject); // Destruir el enemigo si su salud llega a cero o menos
        }
    }
}
