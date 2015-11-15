using UnityEngine;
using System.Collections;

public class levelGenerator : MonoBehaviour {

    public Transform[] prefabs;
    public float timesPerSecound = 30;
    public int currentX = 0;
    public int NumberOfPieces = 500;
    public int currentPieces = 0;
    int prefabLength = 0;
    int rndValue;
    float timesSecoundFixed = 0;

    // Use this for initialization
    void Start () {
        prefabLength = prefabs.Length;
        currentX = 5;
        
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timesSecoundFixed += (timesPerSecound);
        if (!(currentPieces == NumberOfPieces) && timesSecoundFixed >= 60)
        {
            currentPieces += 1;
            rndValue = Random.Range(0, prefabLength);

            Instantiate(prefabs[rndValue], new Vector3(currentX, 0, 0), Quaternion.identity);
            currentX += 5;

            timesSecoundFixed = 0;


        }

	}
}
