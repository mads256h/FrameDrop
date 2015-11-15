using UnityEngine;
using System.Collections;

public class roadGenerator : MonoBehaviour {

    public Transform prefab;
    public float timesPerSecound = 30;
    public int currentX = 0;
    int currentPieces = 0;
    float timesSecoundFixed = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        timesSecoundFixed += (timesPerSecound);
        if (!(currentPieces == levelGenerator.NumberOfPieces) && timesSecoundFixed >= 60)
        {
            currentPieces += 1;

            Instantiate(prefab, new Vector3(currentX, -5, 0), Quaternion.identity);
            currentX += 5;

            timesSecoundFixed = 0;
        }

    }
}
