using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControl : MonoBehaviour
{
    public Vector2 turn;
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        float angle = Mathf.Atan2(turn.y, turn.x)*Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0,0,angle);
    }
}
