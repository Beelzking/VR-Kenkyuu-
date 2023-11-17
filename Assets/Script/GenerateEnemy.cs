using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int yPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount<10)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 31);
            //random spot for enemy, use 1 unit larger than your actual spot//
            Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //spawn emeny, using the random xPos,yPos and zPos you determine//
            yield return new WaitForSeconds(0.5f);
            //time between each spawn//
            enemyCount += 1;
        }    
    }
}
