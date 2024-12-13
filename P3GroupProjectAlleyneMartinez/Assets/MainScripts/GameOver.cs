using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
  
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Over()
    {
        gameOverUI.SetActive(true);
    }
}
