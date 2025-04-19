using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeHitController : MonoBehaviour
{
    public delegate void SpikeCollisionHandler();
    public static event SpikeCollisionHandler OnAxeHitController;
    private int _TwoLife = 2;
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D " + col.gameObject.name);
        if (col.gameObject.tag == "SpinyEnemy")
        {
            Debug.Log("Enemy Collision! AxeHit");
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<SpinyLife>().RemoveLife(col.gameObject, _TwoLife);
        }

        else if (col.gameObject.tag == "ShooterEnemy")
        {
            Debug.Log("Shooter Enemy Collision! FireBall");
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<ShooterEnemyLife>().RemoveLife(col.gameObject, _TwoLife);
        }

        else if (col.gameObject.tag == "Player")
        {
            Debug.Log("Mario Collision! FireBall");
            this.gameObject.SetActive(false);
            GameObject.Find("SC_MarioLifeManager").GetComponent<MarioLifeManager>().RemoveLife(_TwoLife);
            if (OnAxeHitController != null)
                OnAxeHitController();


        }
    }
}
