using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    
    public void AddLife(ILifeAdder playerLife)
    {
        playerLife.AddLife(this.gameObject);
    }

    public void RemoveLife(ILifeRemover playerLife)
    {
        playerLife.RemoveLife(this.gameObject);
    }
}
