using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class EBulletScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] int direction; // -1 left or 1 right
    [SerializeField] float lifetime; // in seconds
    


    int lv = 4;

    void Start()
    {
        moveSpeed *= direction;
    }

    void Update()
    {
        // Move the projectile.
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        // Destroy the propjectile after lifetime.
        Destroy(gameObject, lifetime);

        

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{collision.gameObject.name} triggered me!");
        Destroy(gameObject);
        if (collision.gameObject.name == "Player Parent")
        {
            lv -= 1;
            if (lv == 0)
                Destroy(gameObject);
            //Debug.Log("life" + lv);
        }
        
        

    }
}
