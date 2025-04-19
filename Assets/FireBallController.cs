using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour
{
    public delegate void SpikeCollisionHandler();
    public static event SpikeCollisionHandler OnFireBallController;
    private int _OneLife = 1;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D " + col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Mario Collision! FireBall");
            this.gameObject.SetActive(false);
            GameObject.Find("SC_MarioLifeManager").GetComponent<MarioLifeManager>().RemoveLife(_OneLife);
            if (OnFireBallController != null)
                OnFireBallController();
        }
        else if (col.gameObject.tag == "SpinyEnemy")
        {
            Debug.Log("Enemy Collision! FireBall");
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<SpinyLife>().RemoveLife(col.gameObject);
        }
        else if (col.gameObject.tag == "ShooterEnemy")
        {
            Debug.Log("Shooter Enemy Collision! FireBall");
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<ShooterEnemyLife>().RemoveLife(col.gameObject);
        }
    }

}
