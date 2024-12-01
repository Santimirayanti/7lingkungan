using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------Audio Source--------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------Audio Clip--------")]
    public AudioClip Welcome;

    private void Start()
    {
        musicSource.clip = Welcome;  // Menggunakan 'Welcome' dengan huruf besar
        musicSource.Play();
    }
}
