using UnityEngine;
using System.Collections;

public class gunMovement : MonoBehaviour
{
    public Transform gun;

    Vector3 mousePos;
    Vector3 objectPos;
    float angle = 0;
    void Update()
    {
        //rotation
        mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        gun.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}