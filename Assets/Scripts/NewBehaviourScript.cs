using UnityEngine;

public class BirdController3D : MonoBehaviour
{
    public float jumpForce = 5f; // Kekuatan lompatan
    public float rotationSpeed = 5f; // Kecepatan rotasi burung
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Lompatan dengan tombol Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero; // Reset kecepatan burung
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Rotasi burung (miring ke bawah saat jatuh)
        float tiltAngle = Mathf.Clamp(rb.velocity.y * -rotationSpeed, -90f, 45f);
        transform.rotation = Quaternion.Euler(tiltAngle, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Pipe"))
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0; // Hentikan permainan
    }
}
}
