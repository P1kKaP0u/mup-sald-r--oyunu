using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{


    public Transform attacPoint;
    public LayerMask enemyLayers;

    public float attackRange = 1f;
    public bool hasarverildi = true;



    public void DamagePlayer()
    {

        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attacPoint.position, attackRange, enemyLayers);
        foreach (Collider2D player in hitPlayers)
        {
            Debug.Log("Hasar" + player.name);

            player.GetComponent<Player>().Damage(hasarverildi);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attacPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attacPoint.position, attackRange);
    }

}
