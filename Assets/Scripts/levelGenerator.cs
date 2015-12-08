using UnityEngine;
using System.Collections;

public class levelGenerator : MonoBehaviour {

    public Transform[] prefabs;
    public float timesPerSecound = 30;
    public int currentX = 5;
    public static int NumberOfPieces = 500;

    int currentPieces = 0;
    float timesSecoundFixed = 0;

    int random = 0;
    int timesSpawnedHazardeus = 0;


	
	// Fixed update function is called 60 times per secound
	void FixedUpdate () {

		// Set timesSecoundFixed (Bad naming) to itself plus timesPerSecound
        timesSecoundFixed += (timesPerSecound);

		// If currentPieces is not equal to NumberOfPieces and timesSecoundFixed is higher or equal to 60
        if (!(currentPieces == NumberOfPieces) && timesSecoundFixed >= 60)
        {
            SpawnPrefabs();
			// Reset the timesSecoundFixed
            timesSecoundFixed = 0;


        }


    }
    void SpawnPrefabs()
    {
        random = Random.Range(0, prefabs.Length);
        if (prefabs[random].tag == "Death")
        {
            timesSpawnedHazardeus += 1;
            if (timesSpawnedHazardeus >= 2)
            {
                SpawnPrefabs();
                timesSpawnedHazardeus = 0;
                Instantiate(prefabs[0], new Vector3(currentX, 0, 0), Quaternion.identity);

                Instantiate(prefabs[0], new Vector3(-currentX, 0, 0), Quaternion.identity);
                currentX += 5;
            }
            else
            {
                currentPieces += 1;
                // Make the prefab in the world
                Instantiate(prefabs[random], new Vector3(currentX, 0, 0), Quaternion.identity);

                Instantiate(prefabs[random], new Vector3(-currentX, 0, 0), Quaternion.identity);

                // Set the currentX to itself plus 5
                currentX += 5;
                timesSpawnedHazardeus = 0;
            }

        
        }
        else
        {
            currentPieces += 1;
            // Make the prefab in the world
            Instantiate(prefabs[random], new Vector3(currentX, 0, 0), Quaternion.identity);

            Instantiate(prefabs[random], new Vector3(-currentX, 0, 0), Quaternion.identity);

            // Set the currentX to itself plus 5
            currentX += 5;
            timesSpawnedHazardeus = 0;
        }
    }
}
