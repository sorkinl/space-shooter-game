using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    //config parameters
    
    

    //state variables 
    [SerializeField] int score = 0;



    // Start is called before the first frame update

    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    
    public int GetScore()
    {
        return score;
    }

    // Update is called once per frame
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
        
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }
    
}
