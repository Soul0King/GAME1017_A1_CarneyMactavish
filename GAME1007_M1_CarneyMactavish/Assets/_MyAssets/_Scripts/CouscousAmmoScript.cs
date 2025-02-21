using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CouscousAmmoScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Player Parent")
        {
            
            
            Destroy(gameObject);
        }

    }



    

}
