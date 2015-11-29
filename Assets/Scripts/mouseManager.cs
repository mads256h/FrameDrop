using UnityEngine;
using System.Collections;

public class mouseManager : MonoBehaviour {
    public SpriteRenderer cursor;
    public Sprite[] cursors;
    public Sprite blank;
    public static string mouseState = "None";
	// Use this for initialization
	void Start () {
        Cursor.visible = false;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        switch (mouseState.ToLower())
        {
            case "system":
                Cursor.visible = true;
                cursor.sprite = blank;
                break;

            case "none":
                Cursor.visible = false;
                cursor.sprite = cursors[0];
                break;

            case "cursor":
                Cursor.visible = false;
                cursor.sprite = cursors[1];
                break;

            case "pistol":
                Cursor.visible = false;
                cursor.sprite = cursors[2];
                break;

            case "machinegun":
                Cursor.visible = false;
                cursor.sprite = cursors[3];
                break;

            default:
                Cursor.visible = false;
                cursor.sprite = cursors[0];
                break;
        }
	
	}
}
