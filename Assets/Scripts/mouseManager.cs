using UnityEngine;
using System.Collections;

public class mouseManager : MonoBehaviour {


    public Transform cursor;
    public SpriteRenderer cursorSprite;

    public Sprite[] cursors;
    public Sprite blank;
    public static string mouseState = "none";


    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(new Vector3(mousePos.x, mousePos.y, -2));

        cursor.position = objectPos;
    }
	// FixedUpdate is called 60 times per secound
	void FixedUpdate () {

        switch (mouseState.ToLower())
        {
            case "system":
                Cursor.visible = true;
                cursorSprite.sprite = blank;
                break;

            case "none":
                Cursor.visible = false;
                cursorSprite.sprite = cursors[0];
                Debug.Log("Now using none");
                break;

            case "cursor":
                Cursor.visible = false;
                cursorSprite.sprite = cursors[1];
                break;

            case "pistol":
                Cursor.visible = false;
                cursorSprite.sprite = cursors[2];
                break;

            case "machinegun":
                Cursor.visible = false;
                cursorSprite.sprite = cursors[3];
                break;

            default:
                Cursor.visible = false;
                cursorSprite.sprite = cursors[0];
                break;
        }
	
	}
}
