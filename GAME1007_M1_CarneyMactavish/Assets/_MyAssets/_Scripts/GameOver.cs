using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] Button tryAgain;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
    }
}
