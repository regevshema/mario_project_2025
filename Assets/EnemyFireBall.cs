using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBall : MonoBehaviour
{
    public GameObject fireball;
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
        if (fireball == null)
        {
            Debug.LogWarning("No fireball prefab assigned.");
            return;
        }

        GameObject spawnedFireball = Instantiate(fireball, transform.position, Quaternion.identity);

        ProjectileFireball fireballScript = spawnedFireball.GetComponent<ProjectileFireball>();
        if (fireballScript != null && _pos != null)
        {
            float direction = _pos.localScale.x; 
            fireballScript.Shoot(direction);
        }
    }

    public void updatePos(Transform pos)
    {
        _pos = pos;
        StartCoroutine(FireRoutine());
    }

    

}
