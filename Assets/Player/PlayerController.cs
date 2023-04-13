using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement Variables
    public float accel, speed, maxSpeed;

    void Update()
    {
        //Movemet Script
        float xDir = Input.GetAxis("Horizontal") * Mathf.Lerp(speed, maxSpeed, accel) * Time.deltaTime;
        float yDir = Input.GetAxis("Vertical") * Mathf.Lerp(speed, maxSpeed, accel) * Time.deltaTime;

        transform.Translate(xDir, yDir, 0);
    }
}
