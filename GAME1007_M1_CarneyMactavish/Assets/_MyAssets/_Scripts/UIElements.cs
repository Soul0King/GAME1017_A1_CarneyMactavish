using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIElements : MonoBehaviour
{

    [SerializeField] PBulletScript pb;
    [SerializeField] EBulletScript eb;
    [SerializeField] EnemtScript enemt;
    [SerializeField] TMP_Text score;
    [SerializeField] Bro b;

    

    void Start()
    {
        
    }

    void Update()
    {
        //score.text = pb.sc.ToString();
        //Debug.Log(pb.sc);
    }
}
