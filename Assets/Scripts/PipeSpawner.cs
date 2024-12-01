using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;  // Prefab pipa yang akan di-*spawn*
    public float spawnInterval = 2f; // Jarak waktu antar pipa
    public float pipeSpeed = 5f; // Kecepatan gerak pipa
    public float minY = -2f;  // Batas bawah spawn pipa
    public float maxY = 2f;   // Batas atas spawn pipa
    public float pipeLifetime = 10f; // Waktu hidup pipa sebelum dihapus

    private void Start()
    {
        // Mulai fungsi spawn secara berulang
        InvokeRepeating("SpawnPipe", 1f, spawnInterval);
    }

    private void SpawnPipe()
    {
        // Tentukan posisi acak untuk pipa
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0);
// Spawn pipa
        GameObject newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        // Tambahkan gerakan pada pipa
        Rigidbody2D rb = newPipe.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = new Vector2(-pipeSpeed, 0);

        // Hapus pipa setelah beberapa detik
        Destroy(newPipe, pipeLifetime);
    }
}

