using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip[] musicClips;

    public bool playNext = false;
    int currentSong = 0;


	// Use this for initialization
	void Start () {
        if (playNext)
        {
            playNextSong();
        }
        else
        {
            playRandomSong();
        }
	}
	
	// Play Random song
    void playRandomSong()
    {
        audioSource.clip = musicClips[Random.Range(0, musicClips.Length)];
        audioSource.Play();
        Invoke("playRandomSong", audioSource.clip.length);
    }

    void playNextSong()
    {
        audioSource.clip = musicClips[currentSong];
        audioSource.Play();
        currentSong += 1;
        if (currentSong == musicClips.Length + 1)
        {
            currentSong = 0;
        }
        Invoke("playNextSong", audioSource.clip.length);

    }
}
