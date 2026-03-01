using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;                     // numero de vidas del jugador
    public TextMeshProUGUI livesText;         // referencia al texto de la ui

    private Vector3 startPosition;            // posicion inicial del jugador

    void Start()
    {
        // guarda la posicion inicial y actualiza el texto al empezar
        startPosition = transform.position;
        UpdateLivesUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // si recibe una bala de alien pierde una vida
        if (other.CompareTag("alienBullet"))
        {
            LoseLife();
            Destroy(other.gameObject); // destruye la bala al impactar
        }
    }

    void LoseLife()
    {
        lives--;           // reduce las vidas en uno
        UpdateLivesUI();   // actualiza el texto en pantalla

        // si no quedan vidas desactiva al jugador
        if (lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void UpdateLivesUI()
    {
        // muestra el numero actual de vidas en la ui
        livesText.text = "Vidas: " + lives;
    }
}