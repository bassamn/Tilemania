using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 10f;
    LayerMask destroyLayers;

    Rigidbody2D myRigidbody;
    PlayerMovement player;
    float xSpeed;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindAnyObjectByType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
        destroyLayers = LayerMask.GetMask("Ground", "Bouncing", "Hazard");
    }

    void Update()
    {
        myRigidbody.linearVelocityX = xSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            FindAnyObjectByType<GameSession>().AddToScore(3);
        }
        else if ((destroyLayers & (1 << collision.gameObject.layer)) != 0)
        {
            Destroy(gameObject);
        }
    }
}
