using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour

    
{
       public Text highScore;

    void Start()
    {
       highScore.text = "Highscore : " + (int)PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ToRules()
    {
        SceneManager.LoadScene("Rules");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
