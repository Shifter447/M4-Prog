using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 7f;
    public float jumpForce = 10f;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal * moveSpeed, rb.linearVelocity.y, 0);
        rb.linearVelocity = movement;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("Springen!");
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Vloer")
        {
            isGrounded = true;
        }
    }
}