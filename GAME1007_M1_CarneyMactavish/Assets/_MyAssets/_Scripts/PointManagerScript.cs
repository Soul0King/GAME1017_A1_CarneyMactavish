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

    public TMP_Text finalScoreVal;
    public TMP_Text finalScoreLabel;
    public TMP_Text highScoreVal;
    public TMP_Text highScoreLabel;


    private static PointManager instance = null;
    public static PointManager Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        //DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore(int points)
    {
        score += points;
        scrv.text = score.ToString();
    }
    public void UpdateHighScore()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (score > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", score);
        }
        finalScoreVal.text = score.ToString();
        highScoreVal.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
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
    
    public void PlayLion()
    {
        aud.clip = audioClips[2];
        aud.Play();
    }
}
