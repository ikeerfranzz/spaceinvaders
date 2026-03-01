using UnityEngine;

public class AlienBullet : MonoBehaviour
{
    public float speed = 5f;      // velocidad a la que baja la bala
    public float lifeTime = 5f;   // tiempo maximo que la bala puede existir

    void Start()
    {
        // destruye la bala automaticamente despues de lifeTime segundos
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // mueve la bala hacia abajo constantemente
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // si colisiona con cualquier objeto la bala se destruye
        Destroy(gameObject);
    }
}