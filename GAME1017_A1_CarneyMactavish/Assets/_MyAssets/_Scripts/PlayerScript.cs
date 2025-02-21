using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject bullletPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] EBulletScript ebs;

    [SerializeField] GameObject l1;
    [SerializeField] GameObject l2;
    [SerializeField] GameObject l3;
    [SerializeField] GameObject l4;
    [SerializeField] GameObject ccUI;
    [SerializeField] GameObject ccShot;

    [SerializeField] GameObject splode;
    [SerializeField] Transform esp;

    private PointManager pointManager;

    public int lv = 4;
    public int ccAmmount = 0;

    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        pointManager.scrv.gameObject.SetActive(true);
    }

    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        
        float verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3 (horizontalMovement, verticalMovement, 0.0f).normalized;
        
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        // spawning a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletInst = Instantiate(bullletPrefab, spawnPoint.position, Quaternion.identity);  
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (ccAmmount == 1)
            {
                GameObject couscousShotInst = Instantiate(ccShot, spawnPoint.position, Quaternion.identity);
                ccAmmount = 0;
                ccUI.SetActive(false);
            }
              
        }
        if (lv == 4)
        {
            l1.SetActive(true);
            l2.SetActive(true);
            l3.SetActive(true);
            l4.SetActive(true);
        }
        if (lv == 3)
        {
            l1.SetActive(true);
            l2.SetActive(true);
            l3.SetActive(true);
            l4.SetActive(false);
        }
        if (lv == 2)
        {
            l1.SetActive(true);
            l2.SetActive(true);
            l3.SetActive(false);
            l4.SetActive(false);
        }
        if (lv == 1)
        {
            l1.SetActive(true);
            l2.SetActive(false);
            l3.SetActive(false);
            l4.SetActive(false);
        }
        if (lv == 0)
        {
            

            l1.SetActive(false);
            l2.SetActive(false);
            l3.SetActive(false);
            l4.SetActive(false);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{collision.gameObject.name} triggered me!aaaaaaaaaaaaaaaaaa");
        
        if (collision.gameObject.name == "EnemyBulletParent(Clone)")
        {
            
            lv -= 1;
            if (lv == 0)
            {

                Destroy(gameObject);
                l1.SetActive(false);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                GameObject explosionInst = Instantiate(splode, esp.position, Quaternion.identity);
                Destroy(explosionInst, 3f);
                pointManager.UpdateHighScore();
                pointManager.scrv.gameObject.SetActive(false);
                SceneManager.LoadScene("RestartScreen", LoadSceneMode.Single);
            }
            //Debug.Log("life" + lv);
        }
        if (collision.gameObject.name == "Asteroid Parent(Clone)")
        {
            lv -= 1;
            if (lv == 0)
            {
                Destroy(gameObject);
                l1.SetActive(false);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                GameObject explosionInst = Instantiate(splode, esp.position, Quaternion.identity);
                Destroy(explosionInst, 3f);
                pointManager.UpdateHighScore();
                pointManager.scrv.gameObject.SetActive(false);
                SceneManager.LoadScene("RestartScreen", LoadSceneMode.Single);
            }
        }
        if (collision.gameObject.name == "Enemy Parent(Clone)")
        {
            lv -= 1;
            if (lv == 0)
            {
                
                Destroy(gameObject);
                l1.SetActive(false);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                GameObject explosionInst = Instantiate(splode, esp.position, Quaternion.identity);
                Destroy(explosionInst, 3f);
                pointManager.UpdateHighScore();
                pointManager.scrv.gameObject.SetActive(false);
                SceneManager.LoadScene("RestartScreen", LoadSceneMode.Single);
            }
        }

        if (collision.gameObject.name == "HealthPack(Clone)")
        {
            lv += 1;
            if (lv > 4)
            {
                lv = 4;
            }
        }
        
        if (collision.gameObject.name == "CouscousAmmo(Clone)")
        {
            ccUI.SetActive(true);
            ccAmmount = 1;
        }


    }

    
}
