using UnityEngine;
using System.Collections;

public class mouseManager : MonoBehaviour {

    public float smooth = 2000.0f;
    public LayerMask layer;
    public GameObject cursor;
    public SpriteRenderer cursorSprite;

    public Sprite[] cursors;
    public Sprite blank;
    public static string mouseState = "none";

    Ray ray;
    RaycastHit hit;



    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50, layer))
        {
            if (hit.transform.gameObject.tag == "cursorFollow")
            {
                Drag(hit);

            }
        }
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

            case "shotgun":
                Cursor.visible = false;
                cursorSprite.sprite = cursors[4];
                break;

            default:
                Cursor.visible = false;
                cursorSprite.sprite = cursors[0];
                break;
        }
	
	}

    public void setCursorBlank()
    {
        cursorSprite.sprite = blank;
    }
    void Drag(RaycastHit hit)
    {
        cursor.transform.position = Vector3.Lerp( cursor.transform.position, hit.point, Time.deltaTime * smooth);
    }
}
