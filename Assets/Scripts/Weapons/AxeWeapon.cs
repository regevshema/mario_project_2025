using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AxeAmmo;

public class AxeWeapon : MonoBehaviour, IWeaponReload
{
    public delegate void AxeShoot();
    public static event AxeShoot OnAxeShoot;
  
    

    public GameObject axe;
    private bool _loaded = false;
    private bool _isEquip = false;

    public bool _ammoAmount = false;
    


    public void Shoot()
    {
       
            if (axe != null && _loaded && _isEquip && /*_axeAmmo.CurrentAmount > 0*/ _ammoAmount)
        {
            GameObject curAxe = Instantiate(axe, transform.position, new Quaternion());
            ProjectileAxe scAxe = curAxe.GetComponent<ProjectileAxe>();
            if (scAxe != null)
            {
                _loaded = false;
                float direction = 1;
                if (transform.parent != null)
                    direction = transform.parent.localScale.x;
                scAxe.Shoot(direction);
                if (OnAxeShoot != null)
                    OnAxeShoot();
            }
        
            }
        else
        {
            Debug.Log("No ammo");
        }
    }
    public void Reload()
    {
        _loaded = true;
    }

    public void Equip()
    {
        _isEquip = true;
    }

    public void AmmoAmount()
    {
        _ammoAmount = true;
        Debug.Log("Axe Ammo set to ture: ");

    }
}