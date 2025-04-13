using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeGrabController : MonoBehaviour
{
    private int _axeAmountOnGround = 3;

   
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D " + col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Mario Collision! PickableAxe");
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<PlayerPowerUp>().CollectPowerUp(new AxePowerUp());
            var axeAmmo = col.gameObject.GetComponentInChildren<AxeAmmo>();
            if (axeAmmo != null)
                col.gameObject.GetComponentInChildren<CollectAmmo>().AddAmmo(axeAmmo,_axeAmountOnGround);




        }
    }
}
