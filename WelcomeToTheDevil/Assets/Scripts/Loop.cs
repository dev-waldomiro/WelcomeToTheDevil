using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    [SerializeField]
    float leftWaypointX = -8f, rightWayPointX = 8f;
    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);

        if(transform.position.x < leftWaypointX)
        {
            transform.position = new Vector2(rightWayPointX, transform.position.y);
        }
    }
}
