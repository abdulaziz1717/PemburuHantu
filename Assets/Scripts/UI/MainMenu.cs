using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Menu");
        //yang di tanda kurung ganti pake nomor index scenenya atau ga nama scenenya cth "MainMenu"
    }
    public void Exit()
    {
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Exits play mode (only executed in editor)
    #endif
    }
}
