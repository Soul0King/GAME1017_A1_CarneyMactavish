using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] Button tryAgain;

    private PointManager pointManager;
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        pointManager.finalScoreVal.gameObject.SetActive(true);
        pointManager.highScoreVal.gameObject.SetActive(true);
        pointManager.finalScoreLabel.gameObject.SetActive(true);
        pointManager.highScoreLabel.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }

    public void MainMenu()
    {
        pointManager.finalScoreVal.gameObject.SetActive(false);
        pointManager.highScoreVal.gameObject.SetActive(false);
        pointManager.finalScoreLabel.gameObject.SetActive(false);
        pointManager.highScoreLabel.gameObject.SetActive(false);
        pointManager.score = 0;
        pointManager.scrv.text = pointManager.score.ToString();
        SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
    }

    
}
