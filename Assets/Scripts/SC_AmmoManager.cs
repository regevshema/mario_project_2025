using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AmmoManager : MonoBehaviour
{
    private readonly IWeaponAmount _weaponAmount;
    public SC_AmmoManager(IWeaponAmount weaponAmount)
    {

        _weaponAmount = weaponAmount;
    }
}
