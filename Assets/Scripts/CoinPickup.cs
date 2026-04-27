using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;

    bool isCollected = false;

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (isCollected == true) {return;}
        
        isCollected = true;
        AudioSource.PlayClipAtPoint(coinPickupSFX, transform.position);
        Destroy(gameObject);
    }
}
