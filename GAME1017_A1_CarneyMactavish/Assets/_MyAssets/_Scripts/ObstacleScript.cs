using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    

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
        if (collision.gameObject.name == "Player Parent")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "CouscousExplosion(Clone)")
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{collision.gameObject.name} collided with me!");




    }
}
