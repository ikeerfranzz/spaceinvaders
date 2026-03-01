using UnityEngine;

public class FatherMovement : MonoBehaviour
{
    public float speed = 2f;           // velocidad horizontal del grupo
    public float dropDistance = 0.5f;  // cuanto baja el grupo al cambiar de direccion
    public float speedIncrease = 0.2f; // incremento de velocidad al destruir un alien

    [Header("Disparo")]
    public GameObject alienBulletPrefab; // prefab de la bala de los aliens
    public float shootInterval = 1f;     // tiempo entre disparos

    private int direction = 1;           // 1 derecha, -1 izquierda
    private bool canChangeDirection = true; // evita multiples cambios seguidos

    void Start()
    {
        // ejecuta el disparo automaticamente cada shootInterval segundos
        InvokeRepeating(nameof(ShootRandomAlien), shootInterval, shootInterval);
    }

    void Update()
    {
        // mueve todo el grupo horizontalmente
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);
    }

    void ShootRandomAlien()
    {
        // si no quedan hijos no dispara
        if (transform.childCount == 0) return;

        // elige un alien aleatorio del grupo
        int randomIndex = Random.Range(0, transform.childCount);
        Transform shooter = transform.GetChild(randomIndex);

        // instancia la bala en la posicion del alien seleccionado
        Instantiate(alienBulletPrefab, shooter.position, Quaternion.identity);
    }

    public void ChangeDirection()
    {
        // evita que se cambie varias veces seguidas
        if (!canChangeDirection) return;

        direction *= -1; // invierte la direccion
        transform.position += Vector3.down * dropDistance; // baja el grupo

        canChangeDirection = false;
        Invoke(nameof(ResetDirectionCooldown), 0.5f); // reactiva el cambio despues de 0.5 segundos
    }

    void ResetDirectionCooldown()
    {
        // permite volver a cambiar direccion
        canChangeDirection = true;
    }

    public void IncreaseSpeed()
    {
        // aumenta la velocidad del grupo cuando muere un alien
        speed += speedIncrease;
    }
}