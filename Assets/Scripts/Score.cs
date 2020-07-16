using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0.0f;
    public Text scoreText;
    public Text NHS;
    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;
    private bool iSDead = false;
    public DeathMenu deathMenu;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iSDead)
            return;

        if(score >= scoreToNextLevel)
        {
            LevelUp();
        }
        score += Time.deltaTime*difficultyLevel;
        scoreText.text = ((int)score).ToString();
    }

    void LevelUp()
    {
        if(difficultyLevel == maxDifficultyLevel)
        {
            return;
        }
        scoreToNextLevel *= 2;
        difficultyLevel++;
        GetComponent<playerMotor>().SetSpeed(difficultyLevel);
    }

    public void OnDeath()
    {
        iSDead = true;
        if ((int)PlayerPrefs.GetFloat("Highscore") < score)
        {
            NHS.text = "NEW HIGH SCORE!!";
            PlayerPrefs.SetFloat("Highscore", score);
        }
        deathMenu.ToggleEndMenu(score);
    }
}
