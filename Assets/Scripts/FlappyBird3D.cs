using UnityEngine;

public class FlappyBird3D : MonoBehaviour
{
    public float jumpForce = 5f;  // Kekuatan lompat burung
    public float gravityScale = 10f; // Skala gravitasi
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true; // Pastikan gravitasi aktif
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero; // Reset kecepatan vertikal
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Terapkan gravitasi tambahan
        rb.AddForce(Vector3.down * gravityScale, ForceMode.Acceleration);
    }
}
