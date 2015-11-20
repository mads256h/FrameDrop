using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip[] musicClips;

    public bool playNext = false;
    int currentSong = 0;


	// Use this for initialization
	void Start () {

		// if bool playNext is true
        if (playNext)
        {
			//Play nextsong
            playNextSong();
        }
        else
        {
			//Instead of random song
            playRandomSong();
        }
	}
	
	// Play Random song
    void playRandomSong()
    {
		// Set the audioSource.clip to a random one
        audioSource.clip = musicClips[Random.Range(0, musicClips.Length)];

		// Play the song
        audioSource.Play();

		// Invoke the function again after the song has ended
        Invoke("playRandomSong", audioSource.clip.length);
    }

	// Play Next song
    void playNextSong()
    {
		// Set the clip to current song
        audioSource.clip = musicClips[currentSong];

		// Play the clip
        audioSource.Play();

		// Add 1 to currentSong
        currentSong += 1;

		// if currentSong is musicClips.Length + 1
        if (currentSong == musicClips.Length + 1)
        {
			// Set it to 0
            currentSong = 0;
        }

		// Invoke the same function after the clip has ended
        Invoke("playNextSong", audioSource.clip.length);

    }
}
