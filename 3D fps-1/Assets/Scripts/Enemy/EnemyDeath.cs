using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 5;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    public void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
            //  theEnemy.GetComponent<LookPlayer>().enabled = false;
            GlobalScore.scoreValue += 100; 
        }
    }
}