using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a projectile object in the game that moves forward and interacts with other objects upon collision.
/// </summary>
/// <remarks>Attach this component to a GameObject to enable projectile behavior, including movement and collision
/// handling. The projectile applies an initial force in its forward direction and destroys itself when colliding with
/// objects that have a matching tag.</remarks>
public class Shooting : MonoBehaviour
{
    private Rigidbody2D rb;

    [Tooltip("Speed of the projectile")]
    public float speed = 10;
    [Tooltip("Tag of objects that the projectile can collide with")]
    public string tagColision = "Destroyable";
    /// <summary>
    /// Initializes the projectile by applying a forward force based on the specified speed.
    /// </summary>
    void Start()
    {
        // Apply an initial force to the projectile in the upward direction
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed);
    }
    /// <summary>
    /// Checks for collisions with other objects and handles destruction if the collided object's tag matches.
    /// </summary>
    /// <param name="collision"></param>
    /// 
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}