using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] UIElements ui;
    [SerializeField] GameObject pbp;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject splode;
    [SerializeField] Transform esp;

    private PointManager pointManager;


    private void Start()
    {
        
        InvokeRepeating("SpawnBullet", 0f, Random.Range(1, 4));
    }

    void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
        if (transform.position.x <= -8.5f) // eney is oof screen to the left
        {
            transform.position = new Vector3(8.5f, Random.Range(-5.5f, 3.5f), 0f);
        }
        

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log($"{collision.gameObject.name} triggered me!");
        if (collision.gameObject.name == "PlayerBulletParent(Clone)")
        {

            
            

            GameObject explosionInst = Instantiate(splode, esp.position, Quaternion.identity);
            
            Destroy(explosionInst, 0.4f);
            Destroy(gameObject);
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{collision.gameObject.name} collided with me!");

    }

    void SpawnBullet()
    {
        GameObject bulletInst = Instantiate(pbp, spawnPoint.position, Quaternion.identity);
        float randShade = Random.Range(0.85f, 1.0f);
        bulletInst.GetComponentInChildren<SpriteRenderer>().color = new Color(randShade, randShade, randShade);
        
    }
}
