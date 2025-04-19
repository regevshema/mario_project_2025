using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossLife : ILifeRemover
{
    public void RemoveLife(GameObject player, int amount = 1)
    {
       if (player != null)
        {

            MarioLifeManager lifeManager = GameObject.Find("SC_MarioLifeManager").GetComponent<MarioLifeManager>();
            if (lifeManager != null)
            {
                lifeManager.RemoveLife(amount);
                Debug.Log("AddLife Mashroom");
            }
            else
            {
                Debug.LogError("MarioLifeManager not found");
            }


        }
    }
}

