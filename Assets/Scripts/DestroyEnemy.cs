using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // solo muere si recibe una bala del jugador
        if (other.CompareTag("shipBullet"))
        {
            // obtiene la referencia al objeto padre que controla el grupo
            FatherMovement group = GetComponentInParent<FatherMovement>();

            // si existe el padre aumenta la velocidad del grupo
            if (group != null)
            {
                group.IncreaseSpeed();
            }

            // destruye el alien
            Destroy(gameObject);

            // destruye la bala que lo impacto
            Destroy(other.gameObject);
        }
    }
}