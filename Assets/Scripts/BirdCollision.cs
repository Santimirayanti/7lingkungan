using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public GameManager gameManager; // Referensi ke GameManager

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            gameManager.EndGame(); // Akhiri permainan jika bertabrakan dengan rintangan
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Score"))
        {
            collider.enabled = false; // Pastikan zona skor hanya dipicu sekali
            gameManager.AddScore();  // Tambahkan skor
        }
    }
}
