using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaster : MonoBehaviour
{
    
    [SerializeField] GameObject pauseMenu = null;
    bool isPaused;
    public bool GetIsPaused() { return isPaused; }

    // Start is called before the first frame update

   
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            pauseMenu.SetActive(isPaused);

        }
    }

  
}