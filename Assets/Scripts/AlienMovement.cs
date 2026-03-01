using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    private FatherMovement group; // referencia al objeto padre que controla el movimiento del grupo

    void Start()
    {
        // obtiene el script fathermovement del objeto padre
        group = GetComponentInParent<FatherMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // si el alien toca una pared avisa al padre para cambiar la direccion
        if (other.CompareTag("pared"))
        {
            if (group != null)
            {
                group.ChangeDirection();
            }
        }
    }
}