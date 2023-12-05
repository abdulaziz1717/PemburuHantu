using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // define the different states of the game
    public enum GameState
    {
        Gameplay,
        Paused,
        GameOver
    }

    // Store the current state of the game
    public GameState currentState;
    // Store the previous state of the game
    public GameState previousState;

    [Header("UI")]
    public GameObject pauseScreen;
    public GameObject resultsScreen;

    // Flag to check if the game is over
    public bool isGameOver = false;

    void Awake()
    {
        //Warning check to see if there is another singleton of this kind in the game
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("EXTRA " + this + " DELETED");
        }
        DisableScreen();
    }

    void Update()
    {
        // define the behaviour for each state

        switch (currentState)
        {
            case GameState.Gameplay:
                // code for the gameplay state
                CheckForPauseAndResume();
                break;

            case GameState.Paused:
                // code for the paused state
                CheckForPauseAndResume();
                break;

            case GameState.GameOver:
                // code for the game over state
                if (!isGameOver)
                {
                    isGameOver = true;
                    Time.timeScale = 0f; //stop the game entirely
                    Debug.Log("GAME IS OVER");
                    DisplayResults();
                }
                break;

            default:
                Debug.LogWarning("STATE DOES NOT EXIST");
                break;
        }    
    }

    // define the method to change the state of the game
    public void ChangeState(GameState newState)
    {
        currentState = newState;
    }

    public void PauseGame()
    {
        //previousState = currentState;
        if (currentState != GameState.Paused)
        {
            previousState = currentState;
            ChangeState(GameState.Paused);
            Time.timeScale = 0f; // stop the game
            pauseScreen.SetActive(true);
            Debug.Log("Game is paused");
        }
    }

    public void ResumeGame()
    {
        if (currentState == GameState.Paused)
        {
            ChangeState(previousState);
            Time.timeScale = 1f; //resume the game
            pauseScreen.SetActive(false);
            Debug.Log("Game is resumed");
        }
    }

    // define the method to check for pause and resume input
    void CheckForPauseAndResume()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentState == GameState.Paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void DisableScreen()
    {
        pauseScreen.SetActive(false);
        resultsScreen.SetActive(false);
    }

    public void GameOver()
    {
        ChangeState(GameState.GameOver);
    }

    void DisplayResults()
    {
        resultsScreen.SetActive(true);
    }

}
