using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed = 0.5f;
    public Vector3 endposition;
    private Vector3 startposition;
    bool movingLeft;

    private void Awake()
    {
        startposition = transform.position;
    }
    void FixedUpdate()
    {
        if (transform.position == startposition)
            movingLeft = true;

        if (transform.position == endposition)
            movingLeft = false;

        if (movingLeft)
            transform.position = Vector3.MoveTowards(transform.position, endposition, speed * Time.deltaTime);
        else
            transform.position = Vector3.MoveTowards(transform.position, startposition, speed * Time.deltaTime);
    }
}