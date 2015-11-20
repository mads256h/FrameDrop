using UnityEngine;
using System.Collections;

public class roadGenerator : MonoBehaviour {

    public Transform prefab;
    public float timesPerSecound = 30;
    public int currentX = 0;
    int currentPieces = 0;
    float timesSecoundFixed = 0;

    // Fixed update is called 60 times per secound
    void FixedUpdate()
    {
		// add timesPerSecound to timesSecoundFixed
        timesSecoundFixed += (timesPerSecound);

		// if currentPieces is not NumberOfPieces and timesSecoudFixed is equal or greater than 60
        if (!(currentPieces == levelGenerator.NumberOfPieces) && timesSecoundFixed >= 60)
        {
			// Add 1 to currentPieces
            currentPieces += 1;

			// Spawn the prefab
            Instantiate(prefab, new Vector3(currentX, -5, 0), Quaternion.identity);

			// Add 5 to currentX
            currentX += 5;

			// Resey timesSecoundFixed
            timesSecoundFixed = 0;
        }

    }
}
