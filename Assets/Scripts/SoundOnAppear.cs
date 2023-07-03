using UnityEngine;

public class SoundOnAppear : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}