using Unity.Mathematics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    BoxCollider2D myBoxCollider;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        myRigidbody.linearVelocityX = moveSpeed;

        FlipEnemyFacing();
    }

    void FlipEnemyFacing()
    {
        if (myBoxCollider.IsTouchingLayers(LayerMask.GetMask("Ground", "Hazard", "Enemy")))
        {
            transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.linearVelocity.x)), 1f);
            moveSpeed = -moveSpeed;
        }
    }

}
