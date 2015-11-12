using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip[] musicClips;


	// Use this for initialization
	void Start () {
        playNextSong();
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Play next song
    void playNextSong()
    {
        audioSource.clip = musicClips[Random.Range(0, musicClips.Length)];
        audioSource.Play();
        Invoke("playNextSong", audioSource.clip.length);
    }
}
