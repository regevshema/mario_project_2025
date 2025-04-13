using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponAmount 
{
    public int CurrentAmount { get; set; }
    void AddAmount(int amount);
    void DecAmount(int amount);
}
