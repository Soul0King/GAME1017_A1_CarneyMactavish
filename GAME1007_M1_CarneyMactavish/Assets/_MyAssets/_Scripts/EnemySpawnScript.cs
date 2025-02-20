using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnInterval;
    // list fopr active enemy game objects
    [SerializeField] List<GameObject> activeEnemies;

    // Start is called before the first frame update
    private void Start()
    {
        activeEnemies = new List<GameObject>();
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnEnemy();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < activeEnemies.Count; i++)
            {
                Destroy(activeEnemies[i]); // Destroy enemy at posityion i in list
            }
            activeEnemies.Clear(); // clear the list out
        }
    }

    void SpawnEnemy()
    {
        GameObject enemyInst = Instantiate(enemyPrefab, new Vector3(8.5f, Random.Range(-5.5f, 3.5f), 0f), Quaternion.identity, transform);
        float randShade = Random.Range(0.85f, 1.0f);
        enemyInst.GetComponentInChildren<SpriteRenderer>().color = new Color(randShade, randShade, randShade);
        activeEnemies.Add(enemyInst);
    }
}
