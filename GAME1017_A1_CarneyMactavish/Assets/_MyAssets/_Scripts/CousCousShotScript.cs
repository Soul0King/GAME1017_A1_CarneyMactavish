using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CousCousShotScript : MonoBehaviour
{

    [SerializeField] GameObject ccSplode;

    private PointManager pointManager;

    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        
        pointManager.PlayLion();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 3 * Time.deltaTime);
        if (transform.position == Vector3.zero)
        {
            GameObject couscousExplosionInst = Instantiate(ccSplode, Vector3.zero, Quaternion.identity);

            Destroy(couscousExplosionInst, 0.8f);

            Destroy(gameObject);
        }
    }
}
