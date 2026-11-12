using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // A. References
    public Transform playerHead;
    public float moveSpeed = 0.5f;
    public float stopDistance = 3f;

    // B. Update
    void Update()
    {
        if (playerHead == null) return;

        // C. Measure how far away the enemy is
        float distance = Vector3.Distance(
        transform.position,
        playerHead.position
        );

        // D. Only move while outside the stop radius
        if (distance > stopDistance)
        {
            transform.position = Vector3.MoveTowards(
            transform.position,
            playerHead.position,
            moveSpeed * Time.deltaTime
            );
        }

    }
}