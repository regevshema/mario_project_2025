using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    EndTheGame EnterDoor;
    public void Awake()
    {
        EnterDoor = GameObject.Find("EndingDoor").GetComponent<EndTheGame>();
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("KEY COLLECTED ! " + col.gameObject.name);
            EnterDoor.OnGetKey();
            this.gameObject.SetActive(false);


        }
    }

}
