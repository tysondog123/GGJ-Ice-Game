using UnityEngine;

public class AudioControlle : MonoBehaviour
{
    public  AudioSource audioSource;
  public void PlayAudio(AudioClip Audio)
  {
        audioSource.clip = Audio;
        audioSource.Play();
  }
}
