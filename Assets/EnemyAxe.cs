using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAxe : MonoBehaviour
{

    public GameObject Axe;
    public float fireInterval = 5f;
    private Transform _pos;




    private IEnumerator FireRoutine()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(fireInterval);
        }
    }

    private void Shoot()
    {
        if (Axe == null)
        {
            Debug.LogWarning("No fireball prefab assigned.");
            return;
        }

        GameObject spawnedAxe = Instantiate(Axe, transform.position, Quaternion.identity);

        ProjectileAxe AxeScript = spawnedAxe.GetComponent<ProjectileAxe>();
        if (AxeScript != null && _pos != null)
        {
            float direction = _pos.localScale.x; 
            AxeScript.Shoot(direction);
        }
    }

    public void updatePos(Transform pos)
    {
        _pos = pos;
        StartCoroutine(FireRoutine());
    }



}


