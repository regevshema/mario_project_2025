using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILifeRemover 
{
    public void RemoveLife(GameObject playerLife,int amount = 1);
}
