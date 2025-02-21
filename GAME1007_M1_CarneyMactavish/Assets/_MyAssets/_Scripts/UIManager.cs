using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject bButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        bButton.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        bButton.SetActive(false);
    }
}
