using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTurtleInit : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponent<EnemyWeapon>().CollectPowerUp(new FireBallActivate());
    }
}
