using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static AxeWeapon;

public class AxeAmmo : MonoBehaviour,IWeaponAmount
{


    public int CurrentAmount { get; set; } = 0;
    private TextMeshProUGUI _text;
    private AxeWeapon _axeWeapon;

    void Awake()
    {
        _text = GameObject.Find("AxeAmmount").GetComponent<TextMeshProUGUI>();
        _axeWeapon = transform.root.GetComponentInChildren<AxeWeapon>();
        

    }

    private void OnEnable()
    {
        AxeWeapon.OnAxeShoot += OnAxeShoot;
    }

    private void OnDisable()
    {
        AxeWeapon.OnAxeShoot -= OnAxeShoot;
    }


    private void OnAxeShoot()
    {
        DecAmount(1);
    }
    public void AddAmount(int amount)
    {
            CurrentAmount += amount;
            Debug.Log("Axe Ammo: " + CurrentAmount);
            _text.text = "AxeAmount:" + CurrentAmount.ToString();
            if (CurrentAmount > 0)
            {
                
                if (_axeWeapon != null)
                {
                _axeWeapon._ammoAmount = true;
                }
            }
            else
            {
                Debug.Log("No ammo");
            }
    }

    public void DecAmount(int amount)
    {
        if (CurrentAmount > 0)
        {
            CurrentAmount -= amount;
            _text.text = "AxeAmount:" + CurrentAmount.ToString();
        }
        if (CurrentAmount <= 0)
        {
            _axeWeapon._ammoAmount = false;
            
        }
       
 
    }


}
