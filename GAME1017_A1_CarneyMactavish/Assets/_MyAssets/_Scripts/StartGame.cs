using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] Button startGame;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void StartGameButton()
    {
        
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}
