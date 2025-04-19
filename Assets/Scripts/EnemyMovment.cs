using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed = 0.5f;
    public Vector3 endPosition;

    private Vector3 startPosition;
    private bool isMovingToEnd = true;

    private void Awake()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        Vector3 target = isMovingToEnd ? endPosition : startPosition;

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            isMovingToEnd = !isMovingToEnd; 
        }
    }
}