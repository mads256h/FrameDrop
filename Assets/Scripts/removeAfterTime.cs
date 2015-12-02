using UnityEngine;
using System.Collections;

public class removeAfterTime : MonoBehaviour {

    public int AliveSecounds = 8;

	// Use this for initialization
	void Start () {
        Invoke("Remove", AliveSecounds);
	}
    
    void Remove()
    {
        Destroy(this.gameObject);
    }
}
