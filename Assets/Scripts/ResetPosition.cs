using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Vector3 startPositon;
    private void OnEnable()
    {
        SC_Death.OnSpikeCollision += OnSpikeCollision;
        FireBallController.OnFireBallController += OnSpikeCollision;
        AxeHitController.OnAxeHitController += OnSpikeCollision;  

    }
    private void OnDisable()
    {
        SC_Death.OnSpikeCollision -= OnSpikeCollision;
        FireBallController.OnFireBallController -= OnSpikeCollision;
        AxeHitController.OnAxeHitController -= OnSpikeCollision;
    }
    void Awake()
    {
        startPositon = transform.position;
    }

    private void OnSpikeCollision()
    {
        transform.position = startPositon;
    }
}
