using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Transform attacPoint;
    public LayerMask enemyLayers;

    public float attackRange = 1f;
    public bool hasarverildi = true;



    public void DamageEnemy()
    {

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attacPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
             Debug.Log("Hasar" + enemy.name);

            enemy.GetComponent<Enemy>().Damage(hasarverildi);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attacPoint==null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attacPoint.position, attackRange);
    }


}
