using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject Enemigo;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop() 
    {
        while (enemyCount < 15) 
        {
            xPos = Random.Range(-9, 12);
            zPos = Random.Range(-11, 11);
            Instantiate(Enemigo, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            enemyCount += 1;
        }
    }
}
