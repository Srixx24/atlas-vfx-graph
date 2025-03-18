using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip firstClip;
    public AudioClip secondClip;


    private void Start()
    {
        PlayAudio(firstClip);
    }

    private void PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
        Invoke("PlaySecondAudio", clip.length);
    }

    private void PlaySecondAudio()
    {
        // Check clip currently playing then play next
        if (audioSource.clip == firstClip)
            PlayAudio(secondClip);
        else
            PlayAudio(firstClip);
    }
}