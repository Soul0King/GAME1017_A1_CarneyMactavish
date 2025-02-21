using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PBulletScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] int direction; // -1 left or 1 right
    [SerializeField] float lifetime; // in seconds
    private PointManager pointManager;
    public int sc = 100;

    

    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        moveSpeed *= direction;
        pointManager.PlayLaser();
    }

    void Update()
    {
        // Move the projectile.
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        // Destroy the propjectile after lifetime.
        Destroy(gameObject, lifetime);
        Debug.Log("score: " + sc);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log($"{collision.gameObject.name} triggered me!hhhhhhhhhhhh");
        
        if (collision.gameObject.name == "Enemy Parent(Clone)")
        {
            pointManager.PlayExplode();
            pointManager.UpdateScore(100);
        }
        Destroy(gameObject);
        
        
    }
}
