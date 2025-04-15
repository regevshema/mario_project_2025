using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MarioLifeManager : MonoBehaviour
{
    private int _lives = 3; 
    private TextMeshProUGUI _livesText;
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOverEvent;




    private void Awake()
    {
        _livesText = GameObject.Find("Txt_Life").GetComponent<TextMeshProUGUI>();
        
    }
    
    public void AddLife(int amount)
    {
        _lives+= amount;
        _livesText.text = "Life: " + _lives.ToString();


    }

    public void RemoveLife(int amount) {

        if (_lives <= 0)
        {
            _lives = 0;
             if (OnGameOverEvent != null)
                OnGameOverEvent();
            return;
            
        }

        _lives -= amount;
        _livesText.text = "Life: " + _lives.ToString();


    }

}
