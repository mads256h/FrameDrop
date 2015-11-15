using UnityEngine;
using System.Collections;

public class levelGenerator : MonoBehaviour {

    public Transform[] prefabs;
    public float timesPerSecound = 30;
    public int currentX = 5;
    public int NumberOfPieces = 500;
     int currentPieces = 0;
    float timesSecoundFixed = 0;

    // Use this for initialization

	
	// Update is called once per frame
	void FixedUpdate () {
        timesSecoundFixed += (timesPerSecound);
        if (!(currentPieces == NumberOfPieces) && timesSecoundFixed >= 60)
        {
            currentPieces += 1;

            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(currentX, 0, 0), Quaternion.identity);
            currentX += 5;

            timesSecoundFixed = 0;


        }

	}
}
