using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D oder Pfeil links/rechts
        float moveZ = Input.GetAxis("Vertical");   // W/S oder Pfeil hoch/runter

        Vector3 movement = new Vector3(moveX, 0, moveZ) * moveSpeed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
