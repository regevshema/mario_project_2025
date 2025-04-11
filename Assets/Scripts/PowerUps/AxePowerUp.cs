using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePowerUp : IPowerUp
{
    public void ApplyPowerUp(GameObject player)
    {
        if (player != null)
        {
            AxeWeapon axeWeapon = player.GetComponentInChildren<AxeWeapon>();
            if (axeWeapon != null)
                axeWeapon.Equip();
        }
    }
}