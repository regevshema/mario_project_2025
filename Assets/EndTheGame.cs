using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndTheGame : MonoBehaviour
{
    public bool GotKey = false;
    TextMeshProUGUI text;
    public GameObject gameOverScreen;
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOverEvent;

    void Awake()
    {
        text = GameObject.Find("Txt_GameOver").GetComponent<TextMeshProUGUI>();
        gameOverScreen = GameObject.Find("Image_GameOver");
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && GotKey)
        {
            text.text = "You Win !";
            if (OnGameOverEvent != null)
                OnGameOverEvent();
            return;

        }
 
    }

    public void OnGetKey()
    {
        GotKey = true;
    }
}
