using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    public void Retry(){
        SceneManager.LoadScene("Gameplay");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
