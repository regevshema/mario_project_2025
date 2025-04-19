using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBallActivate : IPowerUp
{
    public void ApplyPowerUp(GameObject enemy)
    {
        if (enemy != null)
        {

            EnemyFireBall fireball = enemy.GetComponentInChildren<EnemyFireBall>();
            if (fireball != null)
            {

                fireball.updatePos(enemy.transform);
            }
            else
            {
                Debug.LogWarning("No TestFireBall component found on the enemy.");
            }
        }
    }
}
