using UnityEngine;

public class BuildingHealth : MonoBehaviour
{
    public int maxHealth = 15;      // vida maxima del edificio
    private int currentHealth;      // vida actual

    private Vector3 originalScale;  // escala original para poder reducirla proporcionalmente

    void Start()
    {
        // inicializa la vida y guarda la escala original
        currentHealth = maxHealth;
        originalScale = transform.localScale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // si recibe una bala del jugador o del alien pierde vida
        if (other.CompareTag("shipBullet") || other.CompareTag("alienBullet"))
        {
            TakeDamage();
            Destroy(other.gameObject); // destruye la bala al impactar
        }
    }

    void TakeDamage()
    {
        currentHealth--; // le quita una vida

        // reduce la anchura en funcion de la vida restante
        float scaleReduction = (float)currentHealth / maxHealth;
        transform.localScale = new Vector3(originalScale.x * scaleReduction, originalScale.y, originalScale.z);

        // si llega a 0 el edificio se destruye
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}