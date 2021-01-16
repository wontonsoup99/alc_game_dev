using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemies());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(enemyPrefab) as GameObject;
        a.transform.position = new Vector2(0, 0);
    }
    IEnumarator spawnEnemies()
    {
        while (true)
        {
            yield return new WaitforSeconds(respawnTime);
            spawnEnemy();
            
        }
        
    }
    


}

