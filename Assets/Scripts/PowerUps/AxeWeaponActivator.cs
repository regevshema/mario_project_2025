using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxeWeaponActivator : IPowerUp
{
    public void ApplyPowerUp(GameObject enemy)
    {
        if (enemy != null)
        {

            EnemyAxe Axe = enemy.GetComponentInChildren<EnemyAxe>();
            if (Axe != null)
            {

                Axe.updatePos(enemy.transform);
            }
            else
            {
                Debug.LogWarning("No TestFireBall component found on the enemy.");
            }
        }
    }
}
