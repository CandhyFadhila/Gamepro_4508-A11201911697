using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Easy(){
        SceneManager.LoadScene("EasyLevel");
    }

    public void Hard(){
        SceneManager.LoadScene("Gameplay");
    }

    public void Medium(){
        SceneManager.LoadScene("MediumLevel");
    }

    public void Credits(){
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
