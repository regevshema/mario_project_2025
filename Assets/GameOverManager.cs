using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    private GameObject gameOverScreen;
    private GameObject world;



    void Awake()
    {
        gameOverScreen = GameObject.Find("Image_GameOver");
        world = GameObject.Find("World");
        
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(false); 
        }
        else
        {
            Debug.LogError("GameOver screen not found! Check the name or hierarchy.");
        }
    }

    private void OnEnable()
    {
        MarioLifeManager.OnGameOverEvent += ShowGameOver;
    }
    
    private void OnDisable()
    {
        MarioLifeManager.OnGameOverEvent -= ShowGameOver;
    }
    public void ShowGameOver()
    {
        if (gameOverScreen != null)
            gameOverScreen.SetActive(true);
        if (world != null)
        {
            world.SetActive(false);
        }

    }

  
}
