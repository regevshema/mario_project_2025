using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashroomGrabController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D " + col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Mario Collision! PickableMashroom");
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<PlayerLife>().AddLife(new MashroomLP());
        }
    }
}
