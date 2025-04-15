using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossLife : ILifeRemover
{
    private int _OneLife = 1;
    public void RemoveLife(GameObject player)
    {
       if (player != null)
        {

            MarioLifeManager lifeManager = GameObject.Find("SC_MarioLifeManager").GetComponent<MarioLifeManager>();
            if (lifeManager != null)
            {
                lifeManager.RemoveLife(_OneLife);
                Debug.Log("AddLife Mashroom");
            }
            else
            {
                Debug.LogError("MarioLifeManager not found");
            }


        }
    }
}

