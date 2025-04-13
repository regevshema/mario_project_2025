using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public void AddAmmo(IWeaponAmount weaponAmount,int amount)
    {
        weaponAmount.AddAmount(amount);
    }

    public void DecAmmo(IWeaponAmount weaponAmount, int amount = 1)
    {

        weaponAmount.DecAmount(amount);
    }

    public int getAmmoAmount(IWeaponAmount weaponAmount)
    {
        return weaponAmount.CurrentAmount;
    }
}


