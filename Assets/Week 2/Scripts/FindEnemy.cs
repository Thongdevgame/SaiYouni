using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public List<Enemy> enemies;  

    public Enemy FindEnemyWithSmallestHealth()
    {
        Enemy smallestHealthEnemy = null;
        float smallestHealth = Mathf.Infinity;

        foreach (Enemy enemy in enemies)
        {
            if (enemy.health < smallestHealth)
            {
                smallestHealth = enemy.health;
                smallestHealthEnemy = enemy;
            }
        }
        return smallestHealthEnemy;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        Enemy largestHealthEnemy = null;
        float largestHealth = Mathf.NegativeInfinity;

        foreach (Enemy enemy in enemies)
        {
            if (enemy.health > largestHealth)
            {
                largestHealth = enemy.health;
                largestHealthEnemy = enemy;
            }
        }
        return largestHealthEnemy;
    }

        //----------------------Edit above here --------------------
    }
