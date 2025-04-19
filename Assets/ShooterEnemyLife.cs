using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemyLife : MonoBehaviour,ILifeRemover
{
    private int _lives = 4;


    public void RemoveLife(GameObject enemy, int amount = 1)
    {
        _lives -= amount;
        if (_lives <= 0)
        {

            _lives = 0;
            this.gameObject.SetActive(false);
            return;
        }
        Debug.Log("Shooter Got Hit!!");

       
    }


}
