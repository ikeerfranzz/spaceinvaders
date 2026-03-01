using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;   // velocidad de movimiento horizontal
    [SerializeField] private bool ship = true;   // permite activar o desactivar el control

    public GameObject Bullet; // prefab de la bala del jugador

    void Update()
    {
        // si el control esta desactivado no hace nada
        if (!ship) return;

        Vector3 direccion = Vector3.zero;

        // detecta movimiento a la izquierda
        if (Keyboard.current.leftArrowKey.isPressed)
            direccion.x = -1;

        // detecta movimiento a la derecha
        if (Keyboard.current.rightArrowKey.isPressed)
            direccion.x = 1;

        // mueve la nave en funcion de la direccion y la velocidad
        transform.position += direccion.normalized * speed * Time.deltaTime;

        // si se pulsa espacio dispara
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject newBullet = Instantiate(Bullet, transform.position, transform.rotation);

            // destruye la bala automaticamente despues de 5 segundos
            Destroy(newBullet, 5f);
        }
    }
}