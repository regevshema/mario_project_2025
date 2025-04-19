using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtuleInit : MonoBehaviour
{
    
    void Awake()
    {
        gameObject.GetComponent<EnemyWeapon>().CollectPowerUp(new AxeWeaponActivator());
    }

}
