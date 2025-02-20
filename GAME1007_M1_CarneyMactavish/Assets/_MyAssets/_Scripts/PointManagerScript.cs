using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{

    [SerializeField] AudioClip[] audioClips;

    private AudioSource aud;

    public int score;
    [SerializeField] public TMP_Text scrv;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        
    }

    public void UpdateScore(int points)
    {
        score += points;
        scrv.text = score.ToString();
    }

    public void PlayExplode()
    {
        aud.clip = audioClips[0];
        aud.Play();
    }

    public void PlayLaser()
    {
        aud.clip = audioClips[1];
        aud.Play();
    }
}
