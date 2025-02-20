using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject ObstaclePrefab;
    [SerializeField] float spawnInterval;
    // list fopr active enemy game objects
    [SerializeField] List<GameObject> activeObstacles;

    // Start is called before the first frame update
    private void Start()
    {
        activeObstacles = new List<GameObject>();
        InvokeRepeating("SpawnObstacle", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SpawnObstacle();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < activeObstacles.Count; i++)
            {
                Destroy(activeObstacles[i]); // Destroy enemy at posityion i in list
            }
            activeObstacles.Clear(); // clear the list out
        }
    }

    void SpawnObstacle()
    {
        GameObject ObstacleInst = Instantiate(ObstaclePrefab, new Vector3(8.5f, Random.Range(-5.5f, 3.5f), 0f), Quaternion.identity, transform);
        float randShade = Random.Range(0.85f, 1.0f);
        ObstacleInst.GetComponentInChildren<SpriteRenderer>().color = new Color(randShade, randShade, randShade);
        activeObstacles.Add(ObstacleInst);
    }
}
