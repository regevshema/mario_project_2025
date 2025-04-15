using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MashroomLP : ILifeAdder
{
    private int _OneLife = 1;
    
    public void AddLife(GameObject player)
    {
        if (player != null)
        {

            MarioLifeManager lifeManager = GameObject.Find("SC_MarioLifeManager").GetComponent<MarioLifeManager>();
            if (lifeManager != null)
            {
                lifeManager.AddLife(_OneLife);
                Debug.Log("AddLife Mashroom");
            }
            else
            {
                Debug.LogError("MarioLifeManager not found");
            }

        }
    }
}
